using System;
using System.Collections.Generic;

namespace MvcResume.Models;

public partial class AboutMe
{
    public long Id { get; set; }

    public string? Description { get; set; }

    public int? Age { get; set; }

    public string? Residence { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }
}
