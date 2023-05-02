using System;
using System.Collections.Generic;

namespace DbFirstSample.Models;

public partial class AktifUrunler
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
