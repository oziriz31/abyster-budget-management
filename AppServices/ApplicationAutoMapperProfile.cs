using AutoMapper;

using budget_management.AppServices.Catalog;
using budget_management.AppServices.Finance;
using budget_management.Models.Domain.Catalog;
using budget_management.Models.Domain.Finance;

namespace budget_management.AppServices
{
    public class ApplicationAutoMapperProfile : Profile
    {
        public ApplicationAutoMapperProfile()
        {
            CreateCategoryMaps();
            CreateOperationMaps();
        }

        private void CreateCategoryMaps()
        {
            // Category entity mapping
            CreateMap<Category, CategoryAppService.CategoryDto>();
            CreateMap<CategoryAppService.CreateUpdateCategoryDto, Category>();
        }

        private void CreateOperationMaps()
        {
            // Category entity mapping
            CreateMap<Operation, OperationAppService.OperationDto>();
            CreateMap<OperationAppService.CreateUpdateOperationDto, Operation>();
        }
    }
}
