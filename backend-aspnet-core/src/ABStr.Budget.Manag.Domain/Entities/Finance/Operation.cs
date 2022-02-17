
using ABStr.Budget.Manag.Entities.Catalog;

using System;

using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace ABStr.Budget.Manag.Entities.Finance
{
    public class Operation : Entity<Guid>, IFullAuditedObject
    {
        public decimal Amount { get; set; } 

        /// <summary>
        /// Gets or sets the operation type
        /// </summary>
        public string? Type { get; set; }

        /// <summary>
        /// Gets or sets operation type identifier
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// Gets or sets the operaton type
        /// </summary>
        public OperationType OpType
        {
            get { return (OperationType)TypeId; }
            set
            {
                TypeId = (int)value;
                Type = value.ToString();
            }
        }

        public DateTime CreationTime { get; set; } 
        public Guid? CreatorId { get; set; } 
        public Guid? LastModifierId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public Guid? DeleterId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }

        public virtual int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
