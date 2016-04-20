using System.Data.Entity.Migrations;
using AlphaProject.Migrations.SeedData;
using AlphaProject.Core;

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
            new Person { Name = "Douglas Adams" }
            );
        }
    }
}
