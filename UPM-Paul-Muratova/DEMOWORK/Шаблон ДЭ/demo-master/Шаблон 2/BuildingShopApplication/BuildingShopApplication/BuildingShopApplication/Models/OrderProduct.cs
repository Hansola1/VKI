using System;
using System.Collections.Generic;

namespace BuildingShopApplication.DataControl;

public partial class OrderProduct
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public string? ProductArticle { get; set; }

    public int? Quantity { get; set; }

    public virtual Order? Order { get; set; }

    public virtual Product? ProductArticleNavigation { get; set; }
}
