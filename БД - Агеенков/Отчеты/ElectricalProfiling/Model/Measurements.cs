namespace ElectricalProfiling.Model
{
    class Measurements
    {
        public int ID { get; set; }
        public int Station_ID { get; set; }
        public DateTime Date { get; set; }
        public string MeasurementType { get; set; }
        public int Value { get; set; }
        public string Units { get; set; }
    }
}
