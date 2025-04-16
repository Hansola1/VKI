namespace ElectricalProfiling.Model
{
    public class Measurements
    {
        public int ID { get; set; }
        public int Station_ID { get; set; }
        public DateTime? Date { get; set; }
        public string measurement_type { get; set; }
        public double? Value { get; set; }
        public string Units { get; set; }
    }
}
