using Volo.Abp.Settings;

namespace ABStr.Budget.Manag.Settings;

public class ManagSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ManagSettings.MySetting1));
    }
}
