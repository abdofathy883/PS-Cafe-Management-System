using PlayStation.Infrastructure.Repos.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlayStation.Models;

public partial class Device
{
    public int Id { get; set; }
    [Display(Name = "اسم الجهاز")]
    public string Name { get; set; } = null!;
    [Display(Name = "نوع الجهاز")]
    public string Type { get; set; } = null!;
    [Display(Name = "سعر الساعة")]
    public byte HourlyRate { get; set; }
    public bool IsDeleted { get; set; } = false;
    public virtual ICollection<Session> Sessions { get; set; } = new List<Session>();
}
