using System;
using System.Collections.Generic;

namespace FishShopApplication.Models;

public partial class PickupPoint
{
    public int Id { get; set; }

    public string? AddresNumber { get; set; }

    public string? City { get; set; }

    public string? Street { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
