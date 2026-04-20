using System;
using System.Collections.Generic;

namespace demo.Models;

public partial class ProductName
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
