using PlayStation.Infrastructure.Repos.Repository;
using System;
using System.Collections.Generic;

namespace PlayStation.Models;

public partial class Session : IDeletable
{
    public int Id { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string Status { get; set; } = null!;

    public decimal TotalCost { get; set; }

    public decimal Duration { get; set; }

    public int DeviceId { get; set; }

    public bool IsDeleted { get; set; } = false;

    public virtual Device Device { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
