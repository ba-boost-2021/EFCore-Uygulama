using BilgeAdam.Data.DataAccess;
using BilgeAdam.Data.Dtos;
using BilgeAdam.Data.Manager;
using BilgeAdam.Data.Services.Abstractions;

namespace BilgeAdam.Data.Services.Concretes
{
    public class CategoryService : ICategoryService
    {
        private readonly NorthwindDbContext context;

        public CategoryService()
        {
            context = ContextManager.GetDbContext();
        }

        public List<CategoryListDto> GetAllCategoriesAsOption()
        {
            return context.Categories.Select(
                x => new CategoryListDto
                {
                    Id = x.CategoryID,
                    Name = x.CategoryName
                }).ToList();


            // Category ----> CategoryListDto
            // SELECT * FROM
            // SELECT CategoryID As Id, CategoryName AS Name FROm Categories
        }
    }
}