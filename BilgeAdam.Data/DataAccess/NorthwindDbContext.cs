using BilgeAdam.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace BilgeAdam.Data.DataAccess
{
    public class NorthwindDbContext : DbContext
    {
        public NorthwindDbContext()
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString);
        }
    }
}