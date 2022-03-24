using BilgeAdam.Data.DataAccess;
using BilgeAdam.Data.Dtos;
using BilgeAdam.Data.Services.Abstractions;

namespace BilgeAdam.Data.Services.Concretes
{
    public class EmployeeService : IEmployeeService
    {
        private readonly NorthwindDbContext context;

        public EmployeeService()
        {
            context = new NorthwindDbContext();
        }

        public List<EmployeeViewDto> GetAllEmployee()
        {
            return context.Employees.Select(x => new EmployeeViewDto
            {
                FullName = x.FirstName + " " + x.LastName,
                Phone = x.HomePhone,
                Title = x.Title,
            }).ToList();

            // SELECT FirstName + " " + LastName AS FullName,
            // HomePhone AS Phone,
            // Title As Title
            // FROM Employees 
        }
    }
}