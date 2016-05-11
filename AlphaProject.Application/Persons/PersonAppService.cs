using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlphaProject.Persons.Dtos;
using Abp.Domain.Repositories;
using AutoMapper;
using Abp.Application.Services.Dto;
using Abp.Linq.Extensions;

namespace AlphaProject.Persons
{
    public class PersonAppService : ApplicationService, IPersonAppService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IPersonManager _personManager;
        public PersonAppService(IPersonRepository personRepository,IPersonManager personManager)
        {
            _personRepository = personRepository;
            _personManager = personManager;

        }
   

        public PagedResultOutput<PersonDto> GetPersons(GetPersonsInput input)
        {
            //Logger.Info("Getting Persons for input:" + input.ToString());

            if (input.ProjectId.HasValue)//查询某个项目内的人员
            {
                ///多对多联合查询
                var personsInProject = _personRepository.GetPersonsInProject(input.ProjectId.Value);
                var personCount = personsInProject.Count();
                if (!string.IsNullOrEmpty(input.Name))
                {
                    personsInProject = personsInProject.Where(p => p.Name == input.Name);
                }
                if (input.PersonId.HasValue)
                {
                    personsInProject = personsInProject.Where(p => p.Id == input.PersonId.Value);
                }

                return new PagedResultOutput<PersonDto>(
                    personCount,
                    Mapper.Map<List<PersonDto>>(personsInProject)
                    );
            }
            else//查询所有人员
            {
               // var personCount = _personRepository.Count();
                var persons = _personRepository.GetAll().OrderBy(p => p.Name).PageBy(input);
                if (!string.IsNullOrEmpty(input.Name))
                {
                    persons = persons.Where(p => p.Name == input.Name);
                }
                if (input.PersonId.HasValue)
                {
                    persons = persons.Where(p => p.Id == input.PersonId.Value);
                }
                var personCount = persons.Count();


                return new PagedResultOutput<PersonDto>(
                    personCount,
                    Mapper.Map<List<PersonDto>>(persons)
                    );
            }
          

           
        }


        public void JoinProject(JoinProjectInput input)
        {
            _personManager.JoinProject(input.PersonId,input.ProjectId, input.IsLeader);
        }


        public void QuitProject(QuitProjectInput input)
        {
            _personManager.QuitProject(input.PersonId, input.ProjectId);
        }


        public int CreatePerson(CreatePersonInput input)
        {
            //throw new NotImplementedException();
            int newPersonId = _personRepository.InsertAndGetId(Mapper.Map<Person>(input));
            if (input.UserId.HasValue)
            {
                _personManager.AssignToUser(newPersonId, input.UserId.Value);

            }
            return newPersonId;
        }


        public void DeletePerson(DeletePersonInput input)
        {
           // throw new NotImplementedException();
            
            _personRepository.Delete(p => input.DeletePersonIds.Contains(p.Id));
                
            
        }


        public void UpdatePerson(UpdatePersonInput input)
        {
            //throw new NotImplementedException();
            Person personToUpdate = Mapper.Map<Person>(input);
            _personRepository.Update(personToUpdate);
            if (input.UserId.HasValue)
            {
                _personManager.AssignToUser(input.Id.Value, input.UserId.Value);

            }
          

        }
    }
}
