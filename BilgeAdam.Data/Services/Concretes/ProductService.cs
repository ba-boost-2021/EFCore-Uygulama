using BilgeAdam.Data.DataAccess;
using BilgeAdam.Data.Dtos;
using BilgeAdam.Data.Services.Abstractions;

namespace BilgeAdam.Data.Services.Concretes
{
    public class ProductService : IProductService
    {
        private readonly NorthwindDbContext context;

        public ProductService()
        {
            context = new NorthwindDbContext();
        }

        public List<ProductViewDto> GetProductsByCategoryId(int id)
        {
            return context.Products.Where(x=>x.CategoryID == id).Select(x => new ProductViewDto
            {
                Name = x.ProductName,
                Price = $"{x.UnitPrice.Value} TL", //x.UnitPrice is null ? 0 : x.UnitPrice
                QuantityPerUnit = x.QuantityPerUnit,
                Stock = x.UnitsInStock
            }).ToList();
        }
    }
}