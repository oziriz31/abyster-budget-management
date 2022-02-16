using budget_management.Models.Domain.Finance;

using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace budget_management.AppServices.Finance
{
    public class OperationApService : CrudAppService<Operation,
                OperationApService.OperationDto,
                Guid,
                PagedAndSortedResultRequestDto,
                OperationApService.CreateUpdateOperationDto>, IOperationAppService
    {

        #region Ctor

        public OperationApService(IRepository<Operation, Guid> repository)
            : base(repository)
        {
        }

        #endregion

        #region Dto's

        public class OperationDto : EntityDto<Guid>
        {
            public decimal Amount { get; set; }
            public string? Type { get; set; }
        }

        public class CreateUpdateOperationDto
        {
            public decimal Amount { get; set; }
            public string? Type { get; set; }
        }

        #endregion
    }
}
