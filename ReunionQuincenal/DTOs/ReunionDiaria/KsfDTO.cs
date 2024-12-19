using System;
using System.Collections.Generic;

namespace ReunionWeb.ReunionDiaria.DTOs;


public partial class KsfDTO
{
    public int Idksf { get; set; }

    public string KsfNombre { get; set; } = null!;

    public bool KsfEsta { get; set; }
}
