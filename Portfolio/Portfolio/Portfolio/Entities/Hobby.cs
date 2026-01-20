using System;
using System.Collections.Generic;

namespace Portfolio.Entities;

public partial class Hobby
{
    public int HobbyId { get; set; }

    public string? Title { get; set; }

    public string? IconUrl { get; set; }
}
