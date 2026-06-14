using System;
using System.Collections.Generic;

namespace ElectronicShopApplication.Models;

public partial class PickUp
{
    public int Id { get; set; }

    public string? City { get; set; }

    public string? Street { get; set; }

    public string? Home { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
