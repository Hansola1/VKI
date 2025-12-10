using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using OurDecorApplication.Models;
using System.Collections.Generic;

namespace OurDecorApplication.DataControl
{
    public class ApplicationContext : DbContext
    {
        //public DbSet<User> Users { get; set; }
        //public DbSet<Roles> Roles { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Material> Materials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HANSOLA;Database=OurDecors;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
