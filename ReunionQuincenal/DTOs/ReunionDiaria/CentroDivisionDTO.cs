using Microsoft.AspNetCore.Mvc;

namespace ReunionWeb.ReunionDiaria.DTOs;


    public class CentroDivisionDTO
    {
        public int IdCentro { get; set; }
        public int IdDivision { get; set; }
        public string Cnom { get; set; } = null!;
        public string? Dnombre { get; set; }
    }