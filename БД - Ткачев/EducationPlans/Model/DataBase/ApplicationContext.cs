using Microsoft.EntityFrameworkCore;

namespace EducationPlans.Model.DataBase
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SpecializationSubject> SpecializationSubjects { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<JournalHomework> JournalHomeworks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DANICHLAPTOP;Database=EducationPlans;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
