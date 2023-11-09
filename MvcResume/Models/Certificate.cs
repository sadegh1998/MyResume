using System;
using System.Collections.Generic;

namespace MvcResume.Models;

public partial class Certificate
{
    public long Id { get; set; }

    public string Image { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string SerialNumber { get; set; } = null!;

    public DateTime AchiveDate { get; set; }

    public string Company { get; set; } = null!;
}
