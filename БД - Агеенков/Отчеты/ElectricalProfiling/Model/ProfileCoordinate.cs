namespace ElectricalProfiling.Model
{
    internal class ProfileCoordinate
    {
        public int ID { get; set; }
        public int Profile_ID { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public string Point_Type { get; set; } // 'start', 'end', 'breakpoint'
    }
}
