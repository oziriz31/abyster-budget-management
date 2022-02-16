using budget_management.Models.Builders.Catalog;
using budget_management.Models.Builders.Finance;

using Microsoft.EntityFrameworkCore;

using System.Diagnostics.CodeAnalysis;

using Volo.Abp;

namespace budget_management.Models.Builders
{
    public static class DbContextModelBuilderExtensions
    { 
        public static void ConfigureApplication(
            [NotNull] this ModelBuilder builder,
            Action<ModelBuilderConfigurationOptions>? optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new ModelBuilderConfigurationOptions();
            optionsAction?.Invoke(options);
              
            builder.ConfigureCategory(options);
            builder.ConfigureOperation(options);
            //code omitted for brevity
        }
    }
}
