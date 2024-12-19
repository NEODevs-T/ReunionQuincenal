using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;

using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;


namespace ReunionWeb.Interface;

interface ICargoReuData
{
    List<CargoReuDTO> cargoreuss { get; set; }
    Task<List<CargoReuDTO>> GetAsistencia(string div, string empresa);
}