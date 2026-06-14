using System;
using System.Collections.Generic;

namespace demo.Models;

public partial class Status
{
    public int Id { get; set; }

    public string? Status1 { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    public override string ToString()
    {
        return $"{Status1}";
    }
}
