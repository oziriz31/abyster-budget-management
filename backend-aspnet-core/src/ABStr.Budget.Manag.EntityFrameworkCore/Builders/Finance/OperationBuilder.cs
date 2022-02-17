using ABStr.Budget.Manag.Entities.Finance;

using Microsoft.EntityFrameworkCore;

using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ABStr.Budget.Manag.Builders.Finance
{
    /// <summary>
    /// Represents an operation entity builder
    /// </summary>
    public static partial class OperationBuilder
    {
        #region Methods

        /// <summary> 
        /// Apply entity configuration 
        /// </summary>
        /// <param name="builder">Create table expression builder</param>
        public static void ConfigureOperation(this ModelBuilder builder)
        {
            builder.Entity<Operation>(b =>
            {
                b.ToTable(ManagConsts.DbTablePrefix + "Operation", ManagConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props

                //...
                b.Property(nameof(Operation.Type)).HasMaxLength(10); 
                b.Property(nameof(Operation.Amount)).HasPrecision(18, 4).IsRequired(); 

                b.HasOne(x => x.Category).WithMany().HasForeignKey(x => x.CategoryId).IsRequired(true); 
            });
        }

        #endregion
    }
}
