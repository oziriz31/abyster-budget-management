using ABStr.Budget.Manag.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ABStr.Budget.Manag.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ManagEntityFrameworkCoreModule),
    typeof(ManagApplicationContractsModule)
    )]
public class ManagDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
