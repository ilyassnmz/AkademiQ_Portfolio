using System;
using System.Collections.Generic;

namespace Portfolio.Entities;

public partial class Skill
{
    public int SkillId { get; set; }

    public string? SkillTitle { get; set; }

    public byte? SkillValue { get; set; }
}
