using System;
using System.Collections.Generic;

namespace BuildingShopApplication.DataControl;

public partial class Order
{
    public int Id { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public int? PickupPointId { get; set; }

    public int? ClientId { get; set; }

    public int? Code { get; set; }

    public int? OrderStatusId { get; set; }

    public virtual User? Client { get; set; }

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    public virtual OrderStatus? OrderStatus { get; set; }

    public virtual PickupAddress? PickupPoint { get; set; }
}
