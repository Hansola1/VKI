namespace ShopShoesApplication.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Article { get; set; } 
        public DateTime CreatedDate { get; set; }
        public DateTime DeliveredDate { get; set; }
        public int PointId { get; set; } 
        public int ClientId { get; set; } 
        public int Code { get; set; } 
        public int OrderStatusId { get; set; }

        public Point Point { get; set; }
        public OrderStatus Status { get; set; }
        public OrderPosition Positions { get; set; }
    }
}
