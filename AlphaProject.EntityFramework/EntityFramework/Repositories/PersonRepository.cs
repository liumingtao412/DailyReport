using Abp.EntityFramework;
using AlphaProject.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.EntityFramework.Repositories
{
    public class PersonRepository : AlphaProjectRepositoryBase<Person>,IPersonRepository
    {

        public IQueryable<Person> GetPersonsInProject(int projectId)
        {          
         //利用中间关系表，查询多对多关系的实体   
            var query  = from persons in Context.Persons
                            from t in persons.Person_Projects.Where(x => x.ProjectId==projectId)
                            select persons;

            //var query2 = from persons in Context.Persons
            //             from project in Context.Projects.Where(t => t.ProjectName == "FirstProject")
            //             from t in persons.Person_Projects.Where(t => t.ProjectId == project.Id)
            //             select persons;
            return query;

        }
        public PersonRepository(IDbContextProvider<AlphaProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }
    }
}
