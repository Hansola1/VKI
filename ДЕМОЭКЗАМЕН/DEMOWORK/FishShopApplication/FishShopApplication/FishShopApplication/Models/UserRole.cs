using System;
using System.Collections.Generic;

namespace FishShopApplication.Models;

public partial class UserRole
{
    public int Id { get; set; }

    public string? Role { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
