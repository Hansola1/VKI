using Microsoft.EntityFrameworkCore;
using MorphpediaAPI.Models;

namespace MorphpediaAPI.DataAccess
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Morph> Morphs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=DataAccess/morphpedia.db");
        }
    }
}