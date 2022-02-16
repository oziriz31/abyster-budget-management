using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace budget_management.Models
{

    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class DbContextFactory : IDesignTimeDbContextFactory<BudgetManagDbContext>
    {
        public BudgetManagDbContext CreateDbContext(string[] args)
        {
            //PayougoEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<BudgetManagDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new BudgetManagDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                //.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Portal.Payougo.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }

}
