using System.Data.Common;
using Abp.Zero.EntityFramework;
using BookManagementSystem.Authorization.Roles;
using BookManagementSystem.MultiTenancy;
using BookManagementSystem.Users;

namespace BookManagementSystem.EntityFramework
{
    public class BookManagementSystemDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public BookManagementSystemDbContext()
            : base("BookManagementSystemEntities")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in BookManagementSystemDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of BookManagementSystemDbContext since ABP automatically handles it.
         */
        public BookManagementSystemDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public BookManagementSystemDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
