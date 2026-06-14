using System;
using System.Collections.Generic;

namespace BuildingShopApplication.DataControl;

public partial class User
{
    public int Id { get; set; }

    public int? RoleId { get; set; }

    public string? Surname { get; set; }

    public string? Name { get; set; }

    public string? Firstname { get; set; }

    public string? Password { get; set; }

    public string? Login { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Role? Role { get; set; }
}
