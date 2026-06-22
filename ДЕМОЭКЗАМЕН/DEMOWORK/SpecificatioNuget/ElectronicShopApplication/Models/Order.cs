using System;
using System.Collections.Generic;

namespace ElectronicShopApplication.Models;

public partial class Order
{
    public int Id { get; set; }

    public string? ArtucleProduct { get; set; }

    public DateTime? DateCreate { get; set; }

    public DateTime? DateDilivery { get; set; }

    public int? PickUp { get; set; }

    public int? UserId { get; set; }

    public int? Code { get; set; }

    public int? StatusId { get; set; }

    public virtual PickUp? PickUpNavigation { get; set; }

    public virtual StatusOrder? Status { get; set; }

    public virtual User? User { get; set; }
}
