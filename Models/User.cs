﻿using PlayStation.Infrastructure.Repos.Repository;
using System;
using System.Collections.Generic;

namespace PlayStation.Models;

public partial class User : IDeletable 
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Role { get; set; } = null!;

    public bool IsDeleted { get; set; } = false;

    public virtual ICollection<Expense> Expenses { get; set; } = new List<Expense>();

    public virtual ICollection<Session> Session { get; set; } = new List<Session>();
    public virtual ICollection<LoginSession> LoginSession { get; set; } = new List<LoginSession>();
    public decimal TotalExpense => Expenses.Sum(e => e.Amount);
}
