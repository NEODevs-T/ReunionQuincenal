using System;
using System.Collections.Generic;

namespace ReunionWeb.ReunionDiaria.DTOs;


public class EquipoDTO
{
    public int IdEquipo { get; set; }
    public int IdLinea { get; set; }
    public string EcodEquiEam { get; set; } = null!;
    public string EnombreEam { get; set; } = null!;
    public string EdescriEam { get; set; } = null!;
    public bool EestaEam { get; set; }
    public DateTime Efecha { get; set; }
}
