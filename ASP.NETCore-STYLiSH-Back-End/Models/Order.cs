using System;
using System.Collections.Generic;

namespace ASP.NETCore_STYLiSH_Back_End.Models;

public partial class Order
{
    public int? UserId { get; set; }

    public string? Time { get; set; }

    public int? Total { get; set; }

    public string? UserOrders { get; set; }

    public int OrderId { get; set; }

    public string? PayOrders { get; set; }

    public string? Payment { get; set; }

    public string? Shipping { get; set; }

    public short? Pay { get; set; }

    public string? OrderProducts { get; set; }

    public string? User { get; set; }

    public string? LastFour { get; set; }
}
