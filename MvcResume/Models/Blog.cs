using System;
using System.Collections.Generic;

namespace MvcResume.Models;

public partial class Blog
{
    public long Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string? Author { get; set; }

    public string? Tag { get; set; }
}
