using System;
using System.Collections.Generic;

namespace ElectronicShopApplication.Models;

public partial class StatusOrder
{
    public int Id { get; set; }

    public string? NameStatus { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
