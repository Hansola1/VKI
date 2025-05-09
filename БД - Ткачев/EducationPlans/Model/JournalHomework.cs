namespace EducationPlans.Model
{
    public class JournalHomework 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public int SubjectID { get; set; }
        public int ScheduleID { get; set; }
    }
}
