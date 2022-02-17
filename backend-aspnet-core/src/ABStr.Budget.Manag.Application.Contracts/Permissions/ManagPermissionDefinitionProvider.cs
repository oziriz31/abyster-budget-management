using ABStr.Budget.Manag.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ABStr.Budget.Manag.Permissions;

public class ManagPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ManagPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ManagPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ManagResource>(name);
    }
}
