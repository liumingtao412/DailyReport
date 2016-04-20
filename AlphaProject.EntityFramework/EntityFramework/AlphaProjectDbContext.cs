using System.Data.Common;
using Abp.Zero.EntityFramework;
using AlphaProject.Authorization.Roles;
using AlphaProject.MultiTenancy;
using AlphaProject.Users;
using System.Data.Entity;
using AlphaProject.Core;

namespace AlphaProject.EntityFramework
{
    public class AlphaProjectDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public virtual IDbSet<Task> Tasks { get; set; }
        public virtual IDbSet<Person> Persons { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public AlphaProjectDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in AlphaProjectDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of AlphaProjectDbContext since ABP automatically handles it.
         */
        public AlphaProjectDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public AlphaProjectDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
