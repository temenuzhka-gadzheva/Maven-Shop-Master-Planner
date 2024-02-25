using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MavenShopMasterPlanner.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MavenShopMasterPlannerDbContext>
    {
        public MavenShopMasterPlannerDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                // takes current directory
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<MavenShopMasterPlannerDbContext>();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));

            return new MavenShopMasterPlannerDbContext(optionsBuilder.Options);
        }

    }
}
