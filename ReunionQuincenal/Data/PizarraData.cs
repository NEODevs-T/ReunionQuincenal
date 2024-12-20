using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;


using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;
using ReunionWeb.Interface;

namespace ReunionWeb.Data;

public class PizarraData : IPizarraData
{

    public PizarraData(IHttpClientFactory clientFactory, HttpClient http, NavigationManager navigationManager)
    {
        _http = http;

        _clientFactory = clientFactory;

        _navigationManager = navigationManager;
    }

    private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/Pizarra";
    private const string BaseUrl2 = "http://localhost:5021/api/Pizarra";
    private HttpClient cliente { get; set; } = new HttpClient();
    private HttpClient _http { get; set; } = new HttpClient();
    private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
    private string url { get; set; } = "";
    private readonly IHttpClientFactory _clientFactory;
    private readonly NavigationManager _navigationManager;

    public List<ReunionDTO> reunionditablas { get; set; } = new List<ReunionDTO>();
    public ReunionDTO reuniondia { get; set; } = new ReunionDTO();
    public List<ReunionDTO> reudiatablas { get; set; } = new List<ReunionDTO>();
    public List<CalendarioTrabajoDTO> calentrabajo { get; set; } = new List<CalendarioTrabajoDTO>();
    public List<CambiReuVDTO> listaCambiReu { get; set; } = new List<CambiReuVDTO>();


    public async Task<List<CalendarioTrabajoDTO>> GetTrabajosCalendario(string pais, string centro, string division)
    {

        int reunionQuincenal = 3;
        url = $"{BaseUrl}/GetTrabajosPorCalendario/{pais}/{centro}/{division}/{reunionQuincenal}";
        cliente = _clientFactory.CreateClient();
        return calentrabajo = await cliente.GetFromJsonAsync<List<CalendarioTrabajoDTO>>(url) ?? new List<CalendarioTrabajoDTO>();
    }

    public async Task<List<ReunionDTO>> GetByODT(string ODT, string idcentro, string iddiv)
    {
        url = $"{BaseUrl}GetByODT/{ODT}/{idcentro}/{iddiv}";
        return reunionditablas = await _http.GetFromJsonAsync<List<ReunionDTO>>(url) ?? new List<ReunionDTO>();

    }

    //obtener discrepancias para pendientes y reunion 
    public async Task<List<ReunionDTO>> GetPendientes(string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado)
    {
        int reunionQuincenal = 3;
        string f1Formatiado = f1.ToString("yyyy-MM-dd");
        string f2Formatiado = f2.ToString("yyyy-MM-dd");
        url = $"{BaseUrl}/GetPendientes/{idcentro}/{iddiv}/{f1Formatiado}/{f2Formatiado}/{tipo}/{estado}/{reunionQuincenal}";
        return reudiatablas = await _http.GetFromJsonAsync<List<ReunionDTO>>(url) ?? new List<ReunionDTO>();

    }

    public async Task<List<ReunionDTO>> GetPendientesTurno(string idcentro, string iddiv)
    {
        url = $"{BaseUrl}/GetPendientesTurno/{idcentro}/{iddiv}";
        return reudiatablas = await _http.GetFromJsonAsync<List<ReunionDTO>>(url) ?? new List<ReunionDTO>();

    }

    //historicos
    public async Task<List<ReunionDTO>> GetHistoricos(string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado)
    {
        int reunionQuincenal = 3;
        string f1Formatiado = f1.ToString("yyyy-MM-dd");
        string f2Formatiado = f2.ToString("yyyy-MM-dd");
        url = $"{BaseUrl}/GetHistoricos/{idcentro}/{iddiv}/{f1Formatiado}/{f2Formatiado}/{tipo}/{estado}/{reunionQuincenal}";
        return reunionditablas = await _http.GetFromJsonAsync<List<ReunionDTO>>(url) ?? new List<ReunionDTO>();

    }

    public async Task<List<CambiReuVDTO>> GetPendientesQuincenal2(string idcentro, string iddiv){
        url = $"{BaseUrl}/GetPendientesQuincenal2/{idcentro}/{iddiv}";
        
        List<CambiReuVDTO> listaCambiReus = await _http.GetFromJsonAsync<List<CambiReuVDTO>>(url) ?? new List<CambiReuVDTO>();
        
        listaCambiReu = listaCambiReus.GroupBy(x => x.IdReuDia)
                .Where(g => g.Count() >= 3)
                .Select(g => g.Last())
                .ToList();        
        
        return listaCambiReus;
    }

    //Update Discrepancia
    public async Task<bool> UpdateDiscrepancia(ReunionDTO d, int id, int tipo, string f1, string f2, string estado)
    {
        bool band = false;
        url = $"{BaseUrl}/UpdateDiscrepancia/{id}";
        cliente = _clientFactory.CreateClient();
        mensaje = await cliente.PutAsJsonAsync(url, id);

        try
        {
            string div = "", centro = "";

            if (d.Rdcentro is not null)
            {
                CentroDivisionDTO centrodiv = await GetCentroDivi(d.Rdcentro, d.Rddiv, 1);

                if (centrodiv == null)
                {
                    return false;
                }

                centro = centrodiv.IdCentro.ToString();
                div = centrodiv.IdDivision.ToString();
            }

            if (mensaje.IsSuccessStatusCode)
            {
                band = await mensaje.Content.ReadFromJsonAsync<bool>();
            }

            if (band == true)
            {

                if (tipo == 0)
                {
                    _navigationManager.NavigateTo($"pendientes/{centro}/{div}/{f1}/{f2}/{tipo}/{estado}");
                }
                else if (tipo == 1)
                {
                    _navigationManager.NavigateTo($"reunion/{centro}/{div}/{f1}/{f2}/{tipo}/Reunion");
                }
                else if (tipo == 2)
                {
                    _navigationManager.NavigateTo($"pendientes/{centro}/{div}/{f1}/{f2}/{tipo}/{estado}");
                }
            }

            return true;

        }
        catch (Exception ex)
        {
            return false;
        }

    }

    public async Task<bool> UpdateDiscrepancia2(ReunionDTO d, int id, int tipo, string f1, string f2, string estado, string linea)
    {
        bool band = false;
        url = $"{BaseUrl}/UpdateDiscrepancia2/{id}";
        cliente.Timeout = TimeSpan.FromMinutes(5);
        cliente = _clientFactory.CreateClient();
        mensaje = await cliente.PutAsJsonAsync(url, d);

        try
        {
            string div = "", centro = "";
            if (mensaje.IsSuccessStatusCode)
            {
                band = await mensaje.Content.ReadFromJsonAsync<bool>();
                CentroDivisionDTO centrodiv = new CentroDivisionDTO();
                centrodiv = await GetCentroDivi(d.Rdcentro, d.Rddiv, 1);
                centro = centrodiv.IdCentro.ToString();
                div = centrodiv.IdDivision.ToString();
            }

            if (band == true)
            {
                if (tipo == 0)
                {
                    _navigationManager.NavigateTo($"pendientes/{centro}/{div}/{linea}/{f1}/{f2}/{tipo}/{estado}", forceLoad: true);
                }
                else if (tipo == 1)
                {
                    _navigationManager.NavigateTo($"reunion/{centro}/{div}/Re/{f1}/{f2}/{tipo}/Reunion", forceLoad: true);
                }
                else if (tipo == 2)
                {
                    _navigationManager.NavigateTo($"pendientes/{centro}/{div}/{linea}/{f1}/{f2}/{tipo}/{estado}", forceLoad: true);
                }

                return true;
            }
            else
            {
                return false;
            }

        }
        catch (Exception ex)
        {
            return false;
        }
    }
    
        public async Task<bool> UpdateDiscrepancia3(ReunionDTO d, int id)
    {
        bool band = false;
        url = $"{BaseUrl}/UpdateDiscrepancia2/{id}";
        cliente = _clientFactory.CreateClient();
        mensaje = await cliente.PutAsJsonAsync(url, d);
            if (mensaje.IsSuccessStatusCode)
            {
                band = await mensaje.Content.ReadFromJsonAsync<bool>();
                return band;
            } else
            {
                return band;
            }
    }
    public async Task<ReunionDTO> GetDiscrepantacia(int id)
    {
        url = $"{BaseUrl}/GetDiscrepantacia/{id}";
        return reuniondia = await _http.GetFromJsonAsync<ReunionDTO>(url) ?? new ReunionDTO();

    }


    public async Task<int> InsertDiscrepancia(ReunionDTO discre)
    {
        int data = 0;
        url = $"{BaseUrl}/AddDiscrepancia";
        cliente = _clientFactory.CreateClient();
        mensaje = await cliente.PostAsJsonAsync(url, discre);
        if (mensaje.IsSuccessStatusCode)
        {
            data = discre.IdReuDia;
        }
        return data;
    }


    public async Task<CentroDivisionDTO> GetCentroDivi(string centro, string division, int tipo)
    {
        url = $"http://neo.paveca.com.ve/apineomaster/api/Maestra/GetCentroDivi/{centro}/{division}/{tipo}";
        cliente = _clientFactory.CreateClient();
        return await cliente.GetFromJsonAsync<CentroDivisionDTO>(url) ?? new CentroDivisionDTO();

    }

}