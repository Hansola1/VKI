using Microsoft.EntityFrameworkCore;

namespace ElectricalProfiling.Model.DB
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Areas> Areas { get; set; }
        public DbSet<Profiles> Profiles { get; set; }
        public DbSet<Stations> Stations { get; set; }
        public DbSet<Measurements> Measurements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DANICHLAPTOP;Database=ElectricalProfiling;Trusted_Connection=True;TrustServerCertificate=True;"); 
        }
    }
}