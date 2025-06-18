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
    public SessionType Type { get; set; }
    public bool IsDeleted { get; set; } = false;
    public int DeviceId { get; set; }
    public virtual Device Device { get; set; } = null!;
    public decimal AmountPaid { get; set; }
    public decimal RemainingBalance { get; set; }
    public string? ClientName { get; set; }
    public bool IsCredit { get; set; }
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    public virtual ICollection<SessionTypeChanges> SessionTypeChanges { get; set; } = new List<SessionTypeChanges>();
}

public enum SessionType
{
    Single = 1,
    Multi = 2
}
