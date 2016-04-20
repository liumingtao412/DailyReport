using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlphaProject.Persons.Dtos;
using AlphaProject.Core;
using Abp.Domain.Repositories;
using AutoMapper;

namespace AlphaProject.Persons
{
    public class PersonAppService : ApplicationService, IPersonAppService
    {
        private readonly IRepository<Person> _personRepository;
        public PersonAppService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;

        }
        public GetPersonsOutput GetAllPersons()
        {
            var persons = _personRepository.GetAll();
            return new GetPersonsOutput
            {
                Persons = Mapper.Map<List<PersonDto>>(persons)
            };
        }

        public GetPersonsOutput GetPersonByName(string name)
        {
            var persons = _personRepository.GetAll().Where(p => p.Name == name);
            

            return new GetPersonsOutput
            {
                Persons = Mapper.Map<List<PersonDto>>(persons)
            };
        }

        public GetPersonsOutput GetPersons(GetPersonsInput input)
        {
            Logger.Info("Getting Persons for input:" + input);

            var persons = _personRepository.GetAll();
            if (!string.IsNullOrEmpty(input.Name))
            {
                persons = persons.Where(p=>p.Name==input.Name);
            }

            return new GetPersonsOutput
            {
                Persons = Mapper.Map<List<PersonDto>>(persons)
            };
        }
    }
}
