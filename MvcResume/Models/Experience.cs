using System;
using System.Collections.Generic;

namespace MvcResume.Models;

public partial class Experience
{
    public long Id { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string Company { get; set; } = null!;

    public string JobTitle { get; set; } = null!;

    public string Description { get; set; } = null!;
}
