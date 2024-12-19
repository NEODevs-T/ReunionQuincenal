using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;
using ReunionWeb.DTOs.Maestra;


namespace ReunionWeb.Services
{
    public interface IAPIReunionService
    {

        List<MaestraVDTO> centro { get; set; }
        List<LineaVDTO> lineas { get; set; }
        List<DivisionesVDTO> divisions { get; set; }
        List<KsfDTO> ksfs { get; set; }
        List<RespoReuDTO> resporeu { get; set; }
        List<ReunionDTO> reunionditabla { get; set; }
        List<ReunionDTO> reudiatabla { get; set; }
        List<AsistenReuDTO> asistenreus { get; set; }
        List<CargoReuDTO> cargoreus { get; set; }
        List<StatsAsisDto> StatsAsisDtos { get; set; }
        List<EquipoEamDTO> equipos { get; set; }
        List<EquipoEamDTO> equiposlinea { get; set; }
        List<CalendarioTrabajoDTO> calentrabajo { get; set; }
        RegistroCambiosDTO listaRegistro { get; set; } //= new RegistroCambiosDTO(); 



        Task<List<EquipoEamDTO>> GetEquiposEAM(string cent);
        Task<List<EquipoEamDTO>> GetEquiposID(string idCentro);
        Task<List<EquipoEamDTO>> GetEquiposxlinea(string idLinea);
        Task<List<DivisionesVDTO>> GetBdDiv(string cent);
        Task<List<DivisionesVDTO>> ObtenerDivisionDelCentro(int idCentro);
        Task<List<LineaVDTO>> ObtenerLasLineasPorDivision(int idDivision);
        Task<List<MaestraVDTO>> GetCentrosxEmpresa(string cent);
        Task<List<LineaVDTO>> GetLineas(int idDivision);
        Task<List<KsfDTO>> Getksf();
        Task<List<RespoReuDTO>> GetResReu();
        Task<List<CargoReuDTO>> GetAsistencia(string div, string empresa);
        Task<List<AsistenReuDTO>> GetStatsAsist(string div, string empresa, string f1, string f2);
        Task<List<AsistenReuDTO>> GetListaAsist(string div, string empresa, string f1, string f2);
        Task<string> Postasistencia(List<AsistenReuDTO> asisten);
        Task<string> AddEquipo(EquipoDTO equipo);
        Task<List<ReunionDTO>> GetTrabajosCalendario(string pais, string centro, string division);
        Task<List<EquipoEamDTO>> GetEquiposCentro(string idCentro);

    }
}
