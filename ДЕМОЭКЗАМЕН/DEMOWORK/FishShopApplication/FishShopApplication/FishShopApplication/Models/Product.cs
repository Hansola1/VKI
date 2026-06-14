using System;
using System.Collections.Generic;

namespace FishShopApplication.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Artucle { get; set; }

    public string? Name { get; set; }

    public string? Measurement { get; set; }

    public int? Cost { get; set; }

    public int? SaleMax { get; set; }

    public int? ManufacturerId { get; set; }

    public int? ProviderId { get; set; }

    public int? CategoryId { get; set; }

    public int? Sale { get; set; }

    public int? QuantityStock { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public virtual ProductCategory? Category { get; set; }

    public virtual Manufacturer? Provider { get; set; }

    public virtual Provider? ProviderNavigation { get; set; }
}
