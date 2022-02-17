using System;
using System.Collections.Generic;
using System.Text;
using ABStr.Budget.Manag.Localization;
using Volo.Abp.Application.Services;

namespace ABStr.Budget.Manag;

/* Inherit your application services from this class.
 */
public abstract class ManagAppService : ApplicationService
{
    protected ManagAppService()
    {
        LocalizationResource = typeof(ManagResource);
    }
}
