using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Persons
{
    public interface IPersonRepository : IRepository<Person>
    {
        IQueryable<Person> GetPersonsInProject(int projectId);
    }
}
