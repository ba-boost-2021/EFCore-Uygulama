using BilgeAdam.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace BilgeAdam.Data.DataAccess
{
    public class NorthwindDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString);
        }
    }
}