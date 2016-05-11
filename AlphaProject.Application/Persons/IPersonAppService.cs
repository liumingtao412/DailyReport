using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AlphaProject.Persons.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Persons
{
    public interface IPersonAppService : IApplicationService
    {
        PagedResultOutput<PersonDto> GetPersons(GetPersonsInput input);
        void DeletePerson(DeletePersonInput input);
        int CreatePerson(CreatePersonInput input);
        void UpdatePerson(UpdatePersonInput input);


        void JoinProject(JoinProjectInput input);
        void QuitProject(QuitProjectInput input);
      
    }
}
