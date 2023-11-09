using System;
using System.Collections.Generic;

namespace MvcResume.Models;

public partial class Skill
{
    public long Id { get; set; }

    public string Title { get; set; } = null!;

    public int Percentage { get; set; }

    public int Type { get; set; }
}
