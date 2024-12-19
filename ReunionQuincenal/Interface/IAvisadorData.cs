using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;

using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;


namespace ReunionWeb.Interface;

interface IAvisadorData
{
    List<CambStatDTO> cambiostatus { get; set; }
    List<CambFecDTO> cambiofecha { get; set; }
    RegistroCambiosDTO listaRegistro { get; set; }
    List<CambiReuVDTO> listaCambiReu { get; set; }

    Task<List<CambStatDTO>> GetCambioStatus(int idreu);
    Task<List<CambFecDTO>> GetCambioFecha(int idreu);
    Task<bool> InsertCambioStatus(CambStatDTO status);

    Task<bool> InsertCambioFec(CambFecDTO cambiofec);

    Task<bool> InsertarRegistros(RegistroCambiosDTO registroCambios);

    Task<List<CambiReuVDTO>> GetPendientesQuincenal2(string idcentro, string iddiv);


}