using System;
using System.Collections.Generic;

namespace DbFirstSample.Models;

public partial class CategorySales1996
{
    public string CategoryName { get; set; } = null!;

    public decimal? TotalPrice { get; set; }
}
