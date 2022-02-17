using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ABStr.Budget.Manag;

[Dependency(ReplaceServices = true)]
public class ManagBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Manag";
}
