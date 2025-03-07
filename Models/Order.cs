using System;
using System.Collections.Generic;

namespace PlayStation.Models;

public partial class Order
{
    public int Id { get; set; }

    public decimal Amount { get; set; }

    public DateTime Time { get; set; }

    public int SessionId { get; set; }

    public int UserId { get; set; }

    public bool IsDeleted { get; set; } = false;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Session Session { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
