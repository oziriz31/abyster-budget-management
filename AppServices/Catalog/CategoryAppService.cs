using budget_management.Models.Domain.Catalog;

using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace budget_management.AppServices.Catalog
{
    public class CategoryAppService : CrudAppService<Category,
                CategoryAppService.CategoryDto,
                int,
                PagedAndSortedResultRequestDto,
                CategoryAppService.CreateUpdateCategoryDto>,
        ICategoryService
    {
        #region Ctor

        public CategoryAppService(IRepository<Category, int> repository) : base(repository)
        {
        }

        #endregion

        #region Dto's

        public class CategoryDto : EntityDto<int>
        {
            public string Label { get; set; }
            public string Description { get; set; }
            public int? ParentId { get; set; }
        }

        public class CreateUpdateCategoryDto
        { 
            public string Label { get; set; }
            public string Description { get; set; }
            public int? ParentId { get; set; }
        }

        #endregion
    }
}
