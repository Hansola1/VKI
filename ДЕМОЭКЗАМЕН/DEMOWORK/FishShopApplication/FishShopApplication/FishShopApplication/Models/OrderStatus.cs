using System;
using System.Collections.Generic;

namespace FishShopApplication.Models;

public partial class OrderStatus
{
    public int Id { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
