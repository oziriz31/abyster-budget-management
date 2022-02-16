using budget_management.Models.Builders;
using budget_management.Models.Domain.Catalog;
using budget_management.Models.Domain.Finance;

using Microsoft.EntityFrameworkCore;

using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;

namespace budget_management.Models
{
    [ReplaceDbContext(typeof(IIdentityDbContext))]
    //[ReplaceDbContext(typeof(ITenantManagementDbContext))]
    [ConnectionStringName("Default")]
    public class BudgetManagDbContext
        : AbpDbContext<BudgetManagDbContext>,
        IIdentityDbContext
        //ITenantManagementDbContext
    {
        public BudgetManagDbContext(DbContextOptions<BudgetManagDbContext> options)
            : base(options)
        {
        }

        //Identity
        public DbSet<IdentityUser> Users { get; set; }
        public DbSet<IdentityRole> Roles { get; set; }
        public DbSet<IdentityClaimType> ClaimTypes { get; set; }
        public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
        public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
        public DbSet<IdentityLinkUser> LinkUsers { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Operation> Operations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /* Include modules to your migration db context */

            //modelBuilder.ConfigurePermissionManagement();
            //modelBuilder.ConfigureSettingManagement();
            //modelBuilder.ConfigureBackgroundJobs();
            modelBuilder.ConfigureAuditLogging();
            modelBuilder.ConfigureIdentity();
            //modelBuilder.ConfigureIdentityServer();
            //modelBuilder.ConfigureFeatureManagement();
            //modelBuilder.ConfigureTenantManagement();

            modelBuilder.ConfigureApplication();
            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(PayougoConsts.DbTablePrefix + "YourEntities", PayougoConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}
