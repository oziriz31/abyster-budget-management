using ABStr.Budget.Manag.AppServices.Catalog;
using ABStr.Budget.Manag.AppServices.Finance;
using ABStr.Budget.Manag.Entities.Catalog;
using ABStr.Budget.Manag.Entities.Finance;

using AutoMapper;

namespace ABStr.Budget.Manag;

public class ManagApplicationAutoMapperProfile : Profile
{
    public ManagApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

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
