using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using BookManagementSystem.EntityFramework;

namespace BookManagementSystem
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(BookManagementSystemCoreModule))]
    public class BookManagementSystemDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BookManagementSystemDbContext>());

            Configuration.DefaultNameOrConnectionString = "BookManagementSystemEntities";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
