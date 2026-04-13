using System;
using System.Collections.Generic;

namespace FishShopApplication.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateTime? DataCreated { get; set; }

    public DateTime? DataDelivered { get; set; }

    public int? PickupPointId { get; set; }

    public int? UserId { get; set; }

    public int? CodeDelivered { get; set; }

    public int? StatusId { get; set; }

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    public virtual PickupPoint? PickupPoint { get; set; }

    public virtual OrderStatus? Status { get; set; }

    public virtual User? User { get; set; }
}
