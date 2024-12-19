using System;
using System.Collections.Generic;

namespace ReunionWeb.ReunionDiaria.DTOs;


public class StatsAsisDto
{
    public string Cargo { get; set; } = string.Empty;
    public double Asistencias { get; set; }
    public double Total { get; set; }
}

