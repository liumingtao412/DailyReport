using System.Data.Entity.Migrations;
using AlphaProject.Migrations.SeedData;
using AlphaProject.Persons;
using AlphaProject.Projects;
using AlphaProject.EntityFramework.Repositories;
using AlphaProject.EntityFramework;

namespace AlphaProject.Migrations
{
    
    internal sealed class Configuration : DbMigrationsConfiguration<AlphaProject.EntityFramework.AlphaProjectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AlphaProject";
        }

        protected override void Seed(AlphaProject.EntityFramework.AlphaProjectDbContext context)
        {
            new InitialDataBuilder(context).Build();
            context.Persons.AddOrUpdate(
            p => p.Name,
            new Person { Name = "Isaac Asimov" },
            new Person { Name = "Thomas More" },
            new Person { Name = "George Orwell" },
            new Person { Name = "Douglas Adams" },
            new Person { Name="Jerry" }
            );
            context.Projects.AddOrUpdate(
          p => p.ProjectName,
          new Project { ProjectName = "FirstProject" },
          new Project { ProjectName = "SecondProject" },
          new Project { ProjectName = "ThirdProject" }
          );

            //var personRepository = new PersonRepository(new Abp.EntityFramework.SimpleDbContextProvider<AlphaProject.EntityFramework.AlphaProjectDbContext>(context));
            //var manager = new PersonManager(personRepository);
            //manager.JoinProject(5, 0);
           

        }
    }
}
