using BilgeAdam.Data.DataAccess;
using BilgeAdam.Data.Dtos;
using BilgeAdam.Data.Entities;
using BilgeAdam.Data.Manager;
using BilgeAdam.Data.Services.Abstractions;

namespace BilgeAdam.Data.Services.Concretes
{
    public class EmployeeService : IEmployeeService
    {
        private readonly NorthwindDbContext context;

        public EmployeeService()
        {
            context = ContextManager.GetDbContext();
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

            //var myEmployees = new List<EmployeeViewDto>() { new EmployeeViewDto() { FullName = "Sergen"}, new EmployeeViewDto() };
            //myEmployees.OrderByDescending(x => x.FullName);
            //myEmployees.Contains(new EmployeeViewDto() { FullName = "Sergen" });
            //myEmployees.Where(x => x.FullName.StartsWith("S")).First();
            //myEmployees.Where(x => x.FullName.StartsWith("S")).FirstOrDefault();
            //myEmployees.Where(x => x.FullName.StartsWith("S")).Single();
            //myEmployees.Where(x => x.FullName.StartsWith("S")).SingleOrDefault();

        }
    }
}