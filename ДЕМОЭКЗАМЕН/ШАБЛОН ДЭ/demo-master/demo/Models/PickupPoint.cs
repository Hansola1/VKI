using System;
using System.Collections.Generic;

namespace demo.Models;

public partial class PickupPoint
{
    public int Id { get; set; }

    public string? Adress { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
