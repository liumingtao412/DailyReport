using Abp.Application.Services;
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
        GetPersonsOutput GetAllPersons();
        GetPersonsOutput GetPersons(GetPersonsInput input);
        GetPersonsOutput GetPersonByName(string name);
    }
}
