using AlphaProject.EntityFramework;
using EntityFramework.DynamicFilters;

namespace AlphaProject.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly AlphaProjectDbContext _context;

        public InitialDataBuilder(AlphaProjectDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.DisableAllFilters();

            new DefaultEditionsBuilder(_context).Build();
            new DefaultTenantRoleAndUserBuilder(_context).Build();
            new DefaultLanguagesBuilder(_context).Build();
        }
    }
}
