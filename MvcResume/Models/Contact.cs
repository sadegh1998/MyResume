using System;
using System.Collections.Generic;

namespace MvcResume.Models;

public partial class Contact
{
    public long Id { get; set; }

    public string? Location { get; set; }

    public string Mobile { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Status { get; set; }

    public string? Mapsrc { get; set; }
}
