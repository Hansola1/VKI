using Microsoft.EntityFrameworkCore;

namespace EducationPlans.Model.DataBase
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Student> Student { get; set; } // КАК НАЗЫВАЕТСЯ В БД - ТАК И ТУТ
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<SpecializationSubject> SpecializationSubject { get; set; }
        public DbSet<Journal> Journal { get; set; }
        public DbSet<JournalHomework> JournalHomework { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DANICHLAPTOP;Database=EducationPlans;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
