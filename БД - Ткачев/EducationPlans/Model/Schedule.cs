namespace EducationPlans.Model
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public int ClassID { get; set; }
        public int GroupID { get; set; }
        public int SpecializationSubjectID { get; set; }
    }
}
