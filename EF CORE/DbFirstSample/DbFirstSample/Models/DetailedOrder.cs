using System;
using System.Collections.Generic;

namespace DbFirstSample.Models;

public partial class DetailedOrder
{
    public int OrderId { get; set; }

    public string CompanyName { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public string Çalışan { get; set; } = null!;

    public string Kargo { get; set; } = null!;

    public string Tedarikçi { get; set; } = null!;

    public string CategoryName { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public short Quantity { get; set; }

    public decimal? Ödenen { get; set; }
}
