using System;
using System.Collections.Generic;

namespace demo.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Article { get; set; }

    public int? NameId { get; set; }

    public string? Unit { get; set; }

    public double? Price { get; set; }

    public int? SupplierId { get; set; }

    public int? ManufacturerId { get; set; }

    public int? CategoryId { get; set; }

    public double? Discount { get; set; }

    public double? Count { get; set; }

    public string? Description { get; set; }

    public string? ImagePath { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Manufacturer? Manufacturer { get; set; }

    public virtual ProductName? Name { get; set; }

    public virtual ICollection<OrderArticle> OrderArticles { get; set; } = new List<OrderArticle>();

    public virtual Supplier? Supplier { get; set; }
}
