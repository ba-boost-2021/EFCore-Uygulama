using BilgeAdam.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Data.Services.Abstractions
{
    public interface IEmployeeService
    {
        List<EmployeeViewDto> GetAllEmployee();
    }
}
