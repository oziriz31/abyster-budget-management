using budget_management.Models.Domain.Catalog; 

using Microsoft.EntityFrameworkCore;

using Volo.Abp.EntityFrameworkCore.Modeling;

namespace budget_management.Models.Builders.Catalog
{
    /// <summary>
    /// Represents an catagory entity builder
    /// </summary>
    public static partial class CategoryBuilder
    {
        #region Methods

        /// <summary> 
        /// Apply entity configuration 
        /// </summary>
        /// <param name="builder">Create table expression builder</param>
        public static void ConfigureCategory(this ModelBuilder builder, ModelBuilderConfigurationOptions options)
        {
            builder.Entity<Category>(b =>
            {
                b.ToTable(options.TablePrefix + "Category", options.Schema);
                b.ConfigureByConvention(); //auto configure for the base class props

                //...
                b.Property(nameof(Category.Label)).HasMaxLength(256).IsRequired(); 
                b.Property(nameof(Category.Description)).HasMaxLength(400).IsRequired(false); 

                b.HasOne(x => x.Parent).WithMany().HasForeignKey(x => x.ParentId).IsRequired(false); 
            });
        }

        #endregion
    }
}
