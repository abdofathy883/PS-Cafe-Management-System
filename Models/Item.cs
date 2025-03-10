﻿using System;
using System.Collections.Generic;

namespace PlayStation.Models;

public partial class Item
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public byte Stock { get; set; }

    public bool IsDeleted { get; set; } = false;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
