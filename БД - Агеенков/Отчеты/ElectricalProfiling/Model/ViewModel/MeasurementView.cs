namespace ElectricalProfiling.Model.ViewModel
{
    public class MeasurementView
    {
        public int Id { get; set; }
        public string StationName { get; set; }
        public DateTime? MeasurementDate { get; set; }
        public string MeasurementType { get; set; }
        public double? Value { get; set; }
        public string Unit { get; set; }
        public int ID { get; set; }
    }

}
