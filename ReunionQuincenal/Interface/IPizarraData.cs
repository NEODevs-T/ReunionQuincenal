using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;

using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;


namespace ReunionWeb.Interface;

interface IPizarraData
{
    ReunionDTO reuniondia { get; set; }
    List<ReunionDTO> reudiatablas { get; set; }
    List<CalendarioTrabajoDTO> calentrabajo { get; set; }
    List<CambiReuVDTO> listaCambiReu { get; set; }

    Task<List<CalendarioTrabajoDTO>> GetTrabajosCalendario(string pais, string centro, string division);
    Task<List<ReunionDTO>> GetByODT(string ODT, string idcentro, string iddiv);
    Task<List<ReunionDTO>> GetPendientes(string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado);
    Task<List<ReunionDTO>> GetHistoricos(string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado);
    Task<ReunionDTO> GetDiscrepantacia(int id);
    Task<bool> UpdateDiscrepancia(ReunionDTO d, int id, int tipo, string f1, string f2, string estado);
    Task<bool> UpdateDiscrepancia2(ReunionDTO d, int id, int tipo, string f1, string f2, string estado, string linea);
    Task<bool> UpdateDiscrepancia3(ReunionDTO d, int id);
    Task<int> InsertDiscrepancia(ReunionDTO discre);
    Task<CentroDivisionDTO> GetCentroDivi(string centro, string division, int tipo);
    Task<List<ReunionDTO>> GetPendientesTurno(string idcentro, string iddiv);
    Task<List<CambiReuVDTO>> GetPendientesQuincenal2(string idcentro, string iddiv);


}