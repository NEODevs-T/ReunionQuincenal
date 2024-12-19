using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;

using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;


namespace ReunionWeb.Interface;

interface IRespoReuData
{
    List<RespoReuDTO> resporeus { get; set; }

    Task<List<RespoReuDTO>> GetResReu();
}