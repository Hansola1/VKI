using Microsoft.EntityFrameworkCore;

namespace ElectricalProfiling.Model.DB
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Projects> Project { get; set; }
        public DbSet<Areas> Area { get; set; }
        public DbSet<AreaCoordinate> AreaCoordinate { get; set; }
        public DbSet<Profiles> Profile { get; set; }
        public DbSet<Profiles> ProfileCoordinate { get; set; }
        public DbSet<Stations> Station { get; set; }
        public DbSet<Measurements> Measurement { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DANICHLAPTOP;Database=ElectricalProfiling;Trusted_Connection=True;TrustServerCertificate=True;"); 
        }
    }
}