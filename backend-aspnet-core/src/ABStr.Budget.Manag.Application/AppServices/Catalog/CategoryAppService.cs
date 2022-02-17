using ABStr.Budget.Manag.Entities.Catalog;

using Microsoft.Extensions.DependencyInjection;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ABStr.Budget.Manag.AppServices.Catalog
{
    public class CategoryAppService : CrudAppService<Category,
                CategoryAppService.CategoryDto,
                int,
                PagedAndSortedResultRequestDto,
                CategoryAppService.CreateUpdateCategoryDto>,
        ICategoryService
    {
        #region Ctor

        public CategoryAppService(IRepository<Category, int> repository) 
            : base(repository)
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
         
        public class CreateUpdateCategoryDto: IValidatableObject
        {
            [Required]
            [StringLength(50)]
            public string Label { get; set; }

            [StringLength(400)]
            public string Description { get; set; }

            public int? ParentId { get; set; }

            public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
            {
                if (ParentId > 0)
                {
                    var catRepo = validationContext.GetService<IRepository<Category, int>>();
                    var query = catRepo.GetQueryableAsync().GetAwaiter().GetResult();

                    if(query.Any(x => x.Id == ParentId))
                    {
                        yield return new ValidationResult(
                           $"La catégorie {ParentId} n'est pas valide ou n'existe pas.",
                           new[] { "ParentId" }
                       );
                    }
                }
            }
        }

        #endregion
    }
}
