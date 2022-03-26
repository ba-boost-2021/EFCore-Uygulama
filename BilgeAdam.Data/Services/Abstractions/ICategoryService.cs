using BilgeAdam.Data.Dtos;

namespace BilgeAdam.Data.Services.Abstractions
{
    public interface ICategoryService
    {
        List<CategoryListDto> GetAllCategoriesAsOption();
    }
}
