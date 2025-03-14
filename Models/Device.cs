using PlayStation.Infrastructure.Repos.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlayStation.Models;

public partial class Device : IDeletable
{
    public int Id { get; set; }
    [Display(Name = "اسم الجهاز")]
    public string Name { get; set; } = null!;
    [Display(Name = "نوع الجهاز")]
    public string Type { get; set; } = null!;
    [Display(Name = "سعر الساعة")]
    public decimal HourlyRate { get; set; }
    public decimal HourlyRateForMulti { get; set; } = 0;

    public DevaisStatus status { get; set; } = DevaisStatus.Available;

    public bool IsDeleted { get; set; } = false;
    public virtual ICollection<Session> Sessions { get; set; } = new List<Session>();
}

public enum DevaisStatus
{
    Available = 1,
    NotAvailable = 2,
    UnderMaintenance = 3
}