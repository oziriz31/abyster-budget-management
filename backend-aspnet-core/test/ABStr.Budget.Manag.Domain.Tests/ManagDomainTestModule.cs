using ABStr.Budget.Manag.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ABStr.Budget.Manag;

[DependsOn(
    typeof(ManagEntityFrameworkCoreTestModule)
    )]
public class ManagDomainTestModule : AbpModule
{

}
