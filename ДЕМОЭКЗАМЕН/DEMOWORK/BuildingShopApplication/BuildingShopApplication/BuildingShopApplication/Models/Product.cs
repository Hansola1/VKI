using System;
using System.Collections.Generic;

namespace BuildingShopApplication.DataControl;

public partial class Product
{
    public string Article { get; set; } = null!;

    public string? Name { get; set; }

    public int? Cost { get; set; }

    public int? MaxDiscount { get; set; }

    public int? ManufacturerId { get; set; }

    public int? SupplierId { get; set; }

    public int? CategoryId { get; set; }

    public int? CurrentDiscount { get; set; }

    public int? StockQuantity { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Manufacturer? Manufacturer { get; set; }

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    public virtual Supplier? Supplier { get; set; }
}
