using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sales_Web.Areas.Admin.Models.Accounts;
using Sales_Web.Areas.Admin.Models.Employees;
using Sales_Web.Models.Products;

namespace Sales_Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Employee
        public DbSet<Employee> Employees { get; set; }

        //Product
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        //Account
    }
}
