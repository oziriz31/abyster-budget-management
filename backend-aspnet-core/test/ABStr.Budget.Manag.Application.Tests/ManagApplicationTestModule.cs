using Volo.Abp.Modularity;

namespace ABStr.Budget.Manag;

[DependsOn(
    typeof(ManagApplicationModule),
    typeof(ManagDomainTestModule)
    )]
public class ManagApplicationTestModule : AbpModule
{

}
