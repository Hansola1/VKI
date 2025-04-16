namespace ElectricalProfiling.Model
{
    class Projects
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public int Customer_id {  get; set; }
       public DateTime Start_date {  get; set; }
       public DateTime End_date { get; set; }
    }
}

