using System;
using System.Collections.Generic;

namespace FishShopApplication.Models;

public partial class ProductCategory
{
    public int Id { get; set; }

    public string? Category { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
