using System;
using System.Collections.Generic;

namespace MvcResume.Models;

public partial class Testimonial
{
    public long Id { get; set; }

    public string Image { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string ProjectName { get; set; } = null!;
}
