using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using BookManagementSystem.EntityFramework;

namespace BookManagementSystem.Migrator
{
    [DependsOn(typeof(BookManagementSystemDataModule))]
    public class BookManagementSystemMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<BookManagementSystemDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}