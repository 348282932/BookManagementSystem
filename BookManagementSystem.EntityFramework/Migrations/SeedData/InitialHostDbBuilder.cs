using BookManagementSystem.EntityFramework;
using EntityFramework.DynamicFilters;

namespace BookManagementSystem.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly BookManagementSystemDbContext _context;

        public InitialHostDbBuilder(BookManagementSystemDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
