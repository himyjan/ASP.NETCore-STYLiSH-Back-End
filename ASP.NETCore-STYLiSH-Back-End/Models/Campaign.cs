using System;
using System.Collections.Generic;

namespace ASP.NETCore_STYLiSH_Back_End.Models;

public partial class Campaign
{
    public long ProductId { get; set; }

    public string? Picture { get; set; }

    public string? Story { get; set; }
}
