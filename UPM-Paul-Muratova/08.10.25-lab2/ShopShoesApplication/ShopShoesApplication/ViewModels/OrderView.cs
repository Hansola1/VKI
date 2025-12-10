namespace ShopShoesApplication.ViewModels
{
    class OrderView
    {
        public int Id { get; set; }
        public string Article { get; set; }
        public string Status { get; set; }
        public string PickupAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DeliveredDate { get; set; }
    }
}
