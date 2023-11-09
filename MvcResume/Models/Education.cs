using System;
using System.Collections.Generic;

namespace MvcResume.Models;

public partial class Education
{
    public long Id { get; set; }

    public DateTime GraduationDate { get; set; }

    public string UniversityName { get; set; } = null!;

    public string FieldOfStudy { get; set; } = null!;

    public string Description { get; set; } = null!;
}
