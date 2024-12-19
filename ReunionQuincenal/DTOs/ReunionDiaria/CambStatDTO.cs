using System;
using System.Collections.Generic;

namespace ReunionWeb.ReunionDiaria.DTOs;



public class CambStatDTO
{
    public int IdCambStat { get; set; }

    public int IdReuDia { get; set; }

    public DateTime? Cbfecha { get; set; }

    public string? Cbstat { get; set; }

    public string? Cbuser { get; set; }

    public virtual ReunionDTO? ReuDia { get; set; } = null!;
}