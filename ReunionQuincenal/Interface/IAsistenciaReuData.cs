using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;

using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;


namespace ReunionWeb.Interface;

interface IAsistenciaReuData
{
    List<AsistenReuDTO> asistenreus { get; set; }
    List<StatsAsisDto> StatsAsisDtos { get; set; }

    Task<string> Postasistencia(List<AsistenReuDTO> asisten);
    Task<List<StatsAsisDto>> GetStatsAsist(string div, string empresa, string f1, string f2);
    Task<List<AsistenReuDTO>> GetListaAsist(string div, string empresa, string f1, string f2);
}