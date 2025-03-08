using System;
using System.Collections.Generic;

namespace PlayStation.Models;

public partial class OrderDetail
{
    public int Id { get; set; }

    public int ItemId { get; set; }

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal? TotalPrice { get; set; }

    public int OrderId { get; set; }

    public bool IsDeleted { get; set; } = false;

    public virtual Item Item { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
