using System;
using System.Collections.Generic;

namespace ElectronicShopApplication.Models;

public partial class CategoryProduct
{
    public int Id { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
