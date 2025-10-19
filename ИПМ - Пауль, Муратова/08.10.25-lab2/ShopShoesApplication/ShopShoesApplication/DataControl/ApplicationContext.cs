using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using ShopShoesApplication.Models;

namespace ShopShoesApplication.DataControl
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Provider> Provider { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
        //public DbSet<Order> Order { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HANSOLA;Database=ShopShoes;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
