using System;
using System.Collections.Generic;

namespace ElectronicShopApplication.Models;

public partial class Manufacturer
{
    public int Id { get; set; }

    public string? ManufactureName { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
