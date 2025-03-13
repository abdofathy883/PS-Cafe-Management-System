using PlayStation.Infrastructure.Repos.Repository;
using System;
using System.Collections.Generic;

namespace PlayStation.Models;

public partial class OrderDetail : IDeletable
{
    public int Id { get; set; }

    public int ItemId { get; set; }

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal? TotalPrice { get; set; }

    public int SessionId { get; set; }

    public bool IsDeleted { get; set; } = false;

    public virtual Item Item { get; set; } = null!;

    public virtual Session Session { get; set; } = null!;
}
