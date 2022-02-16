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
            CreateMap<CategoryAppService.CategoryDto, CategoryAppService.CreateUpdateCategoryDto>();
            CreateMap<CategoryAppService.CreateUpdateCategoryDto, Category>();
        }

        private void CreateOperationMaps()
        {
            // Category entity mapping
            CreateMap<Operation, OperationApService.OperationDto>();
            CreateMap<OperationApService.OperationDto, OperationApService.CreateUpdateOperationDto>();
            CreateMap<OperationApService.CreateUpdateOperationDto, Operation>();
        }
    }
}
