using System;
using System.Collections.Generic;

namespace ElectronicShopApplication.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Artucle { get; set; }

    public int? Cost { get; set; }

    public int? ProviderId { get; set; }

    public int? ManufacturerId { get; set; }

    public int? CategoryId { get; set; }

    public int? Sale { get; set; }

    public int? Count { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public virtual CategoryProduct? Category { get; set; }

    public virtual Manufacturer? Manufacturer { get; set; }

    public virtual Provider? Provider { get; set; }
}
