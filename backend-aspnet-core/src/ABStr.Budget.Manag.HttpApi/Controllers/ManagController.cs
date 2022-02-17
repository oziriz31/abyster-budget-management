using ABStr.Budget.Manag.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABStr.Budget.Manag.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ManagController : AbpControllerBase
{
    protected ManagController()
    {
        LocalizationResource = typeof(ManagResource);
    }
}
