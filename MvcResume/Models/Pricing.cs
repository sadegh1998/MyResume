using System;
using System.Collections.Generic;

namespace MvcResume.Models;

public partial class Pricing
{
    public long Id { get; set; }

    public string PlanName { get; set; } = null!;

    public decimal? Price { get; set; }

    public string Period { get; set; } = null!;

    public string Link { get; set; } = null!;

    public string Description { get; set; } = null!;
}
