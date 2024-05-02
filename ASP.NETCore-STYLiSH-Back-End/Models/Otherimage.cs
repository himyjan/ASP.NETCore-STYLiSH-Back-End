using System;
using System.Collections.Generic;

namespace ASP.NETCore_STYLiSH_Back_End.Models;

public partial class Otherimage
{
    public string? ImagesUrl { get; set; }

    public long? Id { get; set; }

    public virtual Product? IdNavigation { get; set; }
}
