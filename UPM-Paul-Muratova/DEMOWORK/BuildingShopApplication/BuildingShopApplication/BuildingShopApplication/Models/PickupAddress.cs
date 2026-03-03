using System;
using System.Collections.Generic;

namespace BuildingShopApplication.DataControl;

public partial class PickupAddress
{
    public int Id { get; set; }

    public string? Addres { get; set; }

    public string? City { get; set; }

    public string? Street { get; set; }

    public string? StreetNumber { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
