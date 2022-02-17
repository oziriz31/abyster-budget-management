using ABStr.Budget.Manag.Entities.Finance;

using System;
using System.ComponentModel.DataAnnotations;

using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ABStr.Budget.Manag.AppServices.Finance
{
    public class OperationAppService : CrudAppService<Operation,
                OperationAppService.OperationDto,
                Guid,
                PagedAndSortedResultRequestDto,
                OperationAppService.CreateUpdateOperationDto>, 
        IOperationAppService
    {

        #region Ctor

        public OperationAppService(IRepository<Operation, Guid> repository)
            : base(repository)
        {
        }

        #endregion

        #region Dto's

        public class OperationDto : EntityDto<Guid>
        {   
            public decimal Amount { get; set; }
            public string? Type { get; set; }
            public int TypeId { get; set; }
            public int CategoryId { get; set; }
            public DateTime CreationTime { get; set; }
            public Guid? CreatorId { get; set; } 
        }

        public class CreateUpdateOperationDto
        { 
            [Range(0, 999.99)]
            public decimal Amount { get; set; }

            [Required]
            public OperationType OpType { get; set; }

            [Required]
            public int CategoryId { get; set; }

            [Required]
            public Guid CreatorId { get; set; } 
        }

        #endregion
    }
}
