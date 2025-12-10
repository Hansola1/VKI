using System;
using System.Collections.Generic;

namespace FishShopApplication.Models;

public partial class OrderProduct
{
    public int Id { get; set; }

    public string? ProductArtucle { get; set; }

    public int? OrderId { get; set; }

    public int? Quantity { get; set; }

    public virtual Order? Order { get; set; }
}
