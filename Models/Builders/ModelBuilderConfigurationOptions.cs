using Volo.Abp.EntityFrameworkCore.Modeling;

namespace budget_management.Models.Builders
{
    public class ModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public ModelBuilderConfigurationOptions()
            : base(AppConstants.DbTablePrefix, AppConstants.DbSchema)
        {
        }
    }
}
