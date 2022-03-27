using BilgeAdam.Data.DataAccess;
using BilgeAdam.Data.Dtos;
using BilgeAdam.Data.Manager;
using BilgeAdam.Data.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace BilgeAdam.Data.Services.Concretes
{
    public class ProductService : IProductService
    {
        private readonly NorthwindDbContext context;

        public ProductService()
        {
            context = ContextManager.GetDbContext();
        }

        public List<ProductViewDto> GetProductsByCategoryId(int id)
        {
            return context.Products.Include(x=>x.Category).Where(x => x.CategoryID == id)
                .Select(x => new ProductViewDto
                {
                    Name = x.ProductName,
                    Price = $"{x.UnitPrice.Value} TL", //x.UnitPrice is null ? 0 : x.UnitPrice
                    QuantityPerUnit = x.QuantityPerUnit,
                    Stock = x.UnitsInStock,
                    CategoryName = x.Category.CategoryName
                }).ToList();
        }
    }


    /*
     SELECT * FROM [Order Details] od 
        INNER JOIN Orders o ON od.OrderID = o.OrderID 
        INNER JOIN Products p ON od.ProductID = p.ProductID 


-- context.OrderDetails.Include(x=>x.Order).Include(x=>x.Product).ToList()

     SELECT * FROM [Order Details] od 
        INNER JOIN Orders o ON od.OrderID = o.OrderID 
        INNER JOIN Customers c ON c.CustomerID = o.CustomerID 

-- context.OrderDetails.Include(x=>x.Order).ThenInclude(x=>x.Customer).ToList()
     */
}