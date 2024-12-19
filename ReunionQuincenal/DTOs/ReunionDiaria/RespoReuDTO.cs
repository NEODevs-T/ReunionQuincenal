using System;
using System.Collections.Generic;

namespace ReunionWeb.ReunionDiaria.DTOs;


public partial class RespoReuDTO
{
    public int IdResReu { get; set; }

    public string Rrnombre { get; set; } = null!;

    public bool Rresta { get; set; }

    public string? Rrdesc { get; set; }

}
