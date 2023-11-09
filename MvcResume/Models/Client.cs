using System;
using System.Collections.Generic;

namespace MvcResume.Models;

public partial class Client
{
    public long Id { get; set; }

    public string Image { get; set; } = null!;

    public string ClientName { get; set; } = null!;

    public string Url { get; set; } = null!;
}
