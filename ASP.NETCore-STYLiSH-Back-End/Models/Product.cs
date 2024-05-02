using System;
using System.Collections.Generic;

namespace ASP.NETCore_STYLiSH_Back_End.Models;

public partial class Product
{
    public long Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public int? Price { get; set; }

    public string? Texture { get; set; }

    public string? Wash { get; set; }

    public string? Place { get; set; }

    public string? Note { get; set; }

    public string? Story { get; set; }

    public string? MainImage { get; set; }

    public string? Category { get; set; }
}
