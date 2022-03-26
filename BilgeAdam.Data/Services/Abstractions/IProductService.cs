using BilgeAdam.Data.Dtos;
using BilgeAdam.Data.Entities;

namespace BilgeAdam.Data.Services.Abstractions
{
    public interface IProductService
    {
        List<ProductViewDto> GetProductsByCategoryId(int id);
    }
}
