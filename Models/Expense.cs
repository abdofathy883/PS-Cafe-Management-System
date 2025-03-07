using System;
using System.Collections.Generic;

namespace PlayStation.Models;

public partial class Expense
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public decimal Amount { get; set; }

    public DateOnly Date { get; set; }

    public bool IsDeleted { get; set; } = false;

    public int? UserId { get; set; }

    public virtual User? User { get; set; }
}
