namespace ElectricalProfiling.Model
{
    class Stations
    {
        public int ID { get; set; }
        public string station_name { get; set; }
        public int Profile_ID { get; set; }
        public string Coordinates { get; set; }
        public double Elevation { get; set; }
    }
}
