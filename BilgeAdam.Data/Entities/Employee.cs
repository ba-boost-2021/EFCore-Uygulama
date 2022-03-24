using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Data.Entities
{
    [Table("Employees")]
    public class Employee
    {
        //[Column("EmployeeID")]
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string HomePhone { get; set; }
        //best practice tablodaki kolonların hepsinin olmasıdır
    }
}
