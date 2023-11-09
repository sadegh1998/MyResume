using System;
using System.Collections.Generic;

namespace MvcResume.Models;

public partial class Portfolio
{
    public long Id { get; set; }

    public string Title { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string ProjectName { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string? Video { get; set; }
}
