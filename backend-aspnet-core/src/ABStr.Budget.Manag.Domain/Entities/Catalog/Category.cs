using System;

using Volo.Abp;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace ABStr.Budget.Manag.Entities.Catalog
{
    /// <summary>
    /// Represents a category
    /// </summary>
    public class Category : Entity<int>, IHasCreationTime, ISoftDelete
    {
        /// <summary>
        /// Gets or sets the label
        /// </summary>
        public string? Label { get; protected set; }
         
        /// <summary>
        /// Gets or sets the label
        /// </summary>
        public string? Description { get; protected set; }

        /// <summary>
        /// Gets or sets the parent category identifier
        /// </summary>
        public int? ParentId { get; protected set; }

        /// <summary>
        /// Gets or sets the creation time
        /// </summary>
        public DateTime CreationTime { get; protected set; }

        /// <summary>
        /// Gets or sets a value indicating whether category is deleted
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets the parent category
        /// </summary>
        public virtual Category? Parent { get; protected set; }
    }
}
