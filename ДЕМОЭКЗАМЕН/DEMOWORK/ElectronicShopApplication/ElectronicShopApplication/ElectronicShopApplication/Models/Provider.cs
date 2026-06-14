using System;
using System.Collections.Generic;

namespace ElectronicShopApplication.Models;

public partial class Provider
{
    public int Id { get; set; }

    public string? NameProvider { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
