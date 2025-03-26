using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkLearn.Model
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Players> Players { get; set; } // DbSet - хранит представления таблицы из БД в формате таблицы.
        public DbSet<Сharacters> Characters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DANICHLAPTOP;Database=BorodinaAV_2207d2;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }*/
    }
}
