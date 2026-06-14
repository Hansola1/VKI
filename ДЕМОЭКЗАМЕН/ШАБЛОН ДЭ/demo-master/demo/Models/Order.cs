using System;
using System.Collections.Generic;

namespace demo.Models;

public partial class Order
{
    public int Id { get; set; }

    public double? Number { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public int? PickupPointId { get; set; }

    public int? UserId { get; set; }

    public double? Code { get; set; }

    public int? StatusId { get; set; }

    public virtual ICollection<OrderArticle> OrderArticles { get; set; } = new List<OrderArticle>();

    public virtual PickupPoint? PickupPoint { get; set; }

    public virtual Status? Status { get; set; }

    public virtual User? User { get; set; }
}
