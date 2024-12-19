using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;


using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;
using ReunionWeb.Interface;

namespace ReunionWeb.Data;
public class MaestraData : IMaestraData
{

    public MaestraData(IHttpClientFactory clientFactory, HttpClient http)
    {
        _http = http;

        _clientFactory = clientFactory;

    }

    private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/Maestra";
    private const string BaseUrl2 = "http://localhost:5021/api/Maestra";
    private HttpClient cliente { get; set; } = new HttpClient();
    private HttpClient _http { get; set; } = new HttpClient();
    private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
    private string url { get; set; } = "";
    public CentroDivisionDTO divicent { get; set; } = new CentroDivisionDTO();
    private readonly IHttpClientFactory _clientFactory;
    public List<MaestraVDTO> maestra { get; set; } = new List<MaestraVDTO>();
    public List<CentrosVDTO> centro { get; set; } = new List<CentrosVDTO>();
    public List<LineaVDTO> lineas { get; set; } = new List<LineaVDTO>();
    public List<DivisionesVDTO> divisions { get; set; } = new List<DivisionesVDTO>();
    public List<EquipoEamDTO> equipos { get; set; } = new List<EquipoEamDTO>();
    public List<EquipoEamDTO> equiposlinea { get; set; } = new List<EquipoEamDTO>();


    public async Task<List<MaestraVDTO>> GetMaestraXLinea(int idlinea)
    {

        url = $"{BaseUrl}/GetMaestraXLinea/{idlinea}";
        cliente = _clientFactory.CreateClient();
        return maestra = await _http.GetFromJsonAsync<List<MaestraVDTO>>(url) ?? new List<MaestraVDTO>();
    }

    public async Task<List<EquipoEamDTO>> GetEquiposEAM(string cent)
    {

        url = $"{BaseUrl}/GetEquipos/{cent}";
        cliente = _clientFactory.CreateClient();
        return equipos = await _http.GetFromJsonAsync<List<EquipoEamDTO>>(url) ?? new List<EquipoEamDTO>(); 

    }
    public async Task<List<EquipoEamDTO>> GetEquiposID(string idCentro)
    {
        url = $"{BaseUrl}/GetEquipos/{idCentro}";
        cliente = _clientFactory.CreateClient();
        return equipos = await cliente.GetFromJsonAsync<List<EquipoEamDTO>>(url) ?? new List<EquipoEamDTO>();

    }
    public async Task<List<EquipoEamDTO>> GetEquiposxlinea(string idLinea)
    {
        url = $"{BaseUrl}/GetEquiposEAMPorLinea/{idLinea}";
        cliente = _clientFactory.CreateClient();
        return equiposlinea = await cliente.GetFromJsonAsync<List<EquipoEamDTO>>(url) ?? new List<EquipoEamDTO>();

    }
    public async Task<List<DivisionesVDTO>> GetBdDiv(string cent)
    {

        url = $"{BaseUrl}/GetBdDiv/{cent}";
        return divisions = await _http.GetFromJsonAsync<List<DivisionesVDTO>>(url) ?? new List<DivisionesVDTO>();
    }

    public async Task<List<DivisionesVDTO>> ObtenerDivisionDelCentro(int idCentro)
    {
        url = $"{BaseUrl}/GetDivisiones/{idCentro}";
        return divisions = await _http.GetFromJsonAsync<List<DivisionesVDTO>>(url) ?? new List<DivisionesVDTO>();
    }

    public async Task<List<CentrosVDTO>> GetCentrosxEmpresa(string cent)
    {
        url = $"{BaseUrl}/GetCentrosJT/{cent}";
        cliente = _clientFactory.CreateClient();
        return centro = await _http.GetFromJsonAsync<List<CentrosVDTO>>(url) ?? new List<CentrosVDTO>();
    }

    public async Task<List<LineaVDTO>> ObtenerLasLineasPorDivision(int idDivision)
    {
        url = $"{BaseUrl}/GetLineas/{idDivision}";
        return lineas = await _http.GetFromJsonAsync<List<LineaVDTO>>(url) ?? new List<LineaVDTO>();
    }

    public async Task<List<LineaVDTO>> GetLineas(int idDivision)
    {
        url = $"{BaseUrl}/GetLineas/{idDivision:int}";
        cliente = _clientFactory.CreateClient();
        return lineas = await cliente.GetFromJsonAsync<List<LineaVDTO>>(url) ?? new List<LineaVDTO>();
    }

    public async Task<string> AddEquipo(EquipoDTO equipo)
    {
        string mens = "";
        url = $"{BaseUrl}/AddEquipo";
        cliente = _clientFactory.CreateClient();
        mensaje = await cliente.PostAsJsonAsync(url, equipo);
        if (mensaje.IsSuccessStatusCode)
        {
            mens = "Se añadido exitosamente";
        }
        return mens;
    }
    public async Task<List<EquipoEamDTO>> GetEquiposCentro(string idCentro)
    {
        url = $"{BaseUrl}/GetEquipos/{idCentro}";
        cliente = _clientFactory.CreateClient();
        return equipos = await cliente.GetFromJsonAsync<List<EquipoEamDTO>>(url) ?? new List<EquipoEamDTO>();
    }

    public async Task<CentroDivisionDTO> GetCentroDiv(string centro, string division, int tipo)
    {
        url = $"{BaseUrl}/GetHistoricos/{centro}/{division}/{tipo}";
        return divicent = await _http.GetFromJsonAsync<CentroDivisionDTO>(url) ?? new CentroDivisionDTO();
    }

        public async Task<List<EquipoEamDTO>> GetEquiposEAMPorLinea(int idLinea)
        {
        url = $"{BaseUrl}/GetEquiposEAMPorLinea/{idLinea}";
        cliente = _clientFactory.CreateClient();
        return equipos = await cliente.GetFromJsonAsync<List<EquipoEamDTO>>(url) ?? new List<EquipoEamDTO>();
        }


}

