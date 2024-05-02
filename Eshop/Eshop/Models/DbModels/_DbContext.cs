using System.Reflection.Emit;
using System.Xml;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Eshop.Models.DbModels
{
    public class _DbContext : DbContext
    {
          public _DbContext(DbContextOptions<_DbContext> options) : base(options)
    {
    }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetail { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategories> ProductCategory { get; set; }
        public DbSet<ProductSubCategories> ProductSubCategory { get; set; }
        public DbSet<ProductGender> ProductGenders { get; set; }
        public DbSet<ProductType> ProductType { get; set; }

        public DbSet<Role> Roles { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Users> User { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			
		}
	}

}

       
    


