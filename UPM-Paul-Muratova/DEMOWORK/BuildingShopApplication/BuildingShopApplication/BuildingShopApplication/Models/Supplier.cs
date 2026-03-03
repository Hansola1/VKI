using System;
using System.Collections.Generic;

namespace BuildingShopApplication.DataControl;

public partial class Supplier
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
