using Microsoft.AspNetCore.Components;

using ReunionWeb.Controllers;
using Microsoft.EntityFrameworkCore;
using ReunionWeb.DTOs;
using System.Diagnostics.Metrics;
using Radzen.Blazor.Rendering;
using System.Linq.Dynamic.Core;
using System.Reflection.Metadata.Ecma335;
using ReunionWeb.ReunionDiaria.DTOs;
using ReunionWeb.DTOs.Maestra;




namespace ReunionWeb.Services;

public class DbReunionService : IDbReunionService
{

    public DbReunionService(NavigationManager navigationManager,IHttpClientFactory clientFactory, HttpClient http)
    {
        _clientFactory = clientFactory;

        _http = http;

        _navigationManager = navigationManager;
    }
    // **-------> CONEXION A LA API <--------**
    private readonly IHttpClientFactory _clientFactory;
    private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/DbReunionService";
    private HttpClient cliente { get; set; } = new HttpClient();
    private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
    private string url { get; set; } = "";
    private HttpClient _http { get; set; } = new HttpClient();

    // **-------> CONEXION A LA API <--------**

        public List<CentrosVDTO> centros { get; set; } = new List<CentrosVDTO>();
        public List<LineaVDTO> lineas { get; set; } = new List<LineaVDTO>();
        public List<EmpresasVDTO> empresas { get; set; } = new List<EmpresasVDTO>();
        public List<PaiDTO> paiss { get; set; } = new List<PaiDTO>();
        public List<DivisionesVDTO> divs { get; set; } = new List<DivisionesVDTO>();
        public List<KsfDTO> ksfss { get; set; } = new List<KsfDTO>();
        public List<RespoReuDTO> resporeus { get; set; } = new List<RespoReuDTO>();
        public List<ReunionDTO> reunionditablas { get; set; } = new List<ReunionDTO>();
        public ReunionDTO reuniondia { get; set; } = new ReunionDTO();
        public List<DivisionesVDTO> divisionss { get; set; } = new List<DivisionesVDTO>();
        public List<AsistenReuDTO> asistenreus { get; set; } = new List<AsistenReuDTO>();
        public List<CargoReuDTO> cargoreuss { get; set; } = new List<CargoReuDTO>();
        public List<CambStatDTO> cambiostatus { get; set; } = new List<CambStatDTO>();
        public List<CambFecDTO> cambioFecha { get; set; } = new List<CambFecDTO>();
        public DivisionesVDTO centrodiscrepancia { get; set; } = new DivisionesVDTO();
        public CentroDivisionDTO divicent {get; set; } = new CentroDivisionDTO();


    private readonly NavigationManager _navigationManager;


    public async Task<List<ReunionDTO>> GetByODT(string ODT, string idcentro, string iddiv)
    {
        url = $"{BaseUrl}GetByODT/{ODT}/{idcentro}/{iddiv}";
        return reunionditablas = await _http.GetFromJsonAsync<List<ReunionDTO>>(url) ?? new List<ReunionDTO>();

    }

    //obtener discrepancias para pendientes y reunion 
    public async Task<List<ReunionDTO>> GetPendientes(string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado)
    {
        string f1Formatiado = f1.ToString("yyyy-MM-dd");
        string f2Formatiado = f2.ToString("yyyy-MM-dd");
        url = $"{BaseUrl}/GetPendientes/{idcentro}/{iddiv}/{f1Formatiado}/{f2Formatiado}/{tipo}/{estado}";
        return reunionditablas = await _http.GetFromJsonAsync<List<ReunionDTO>>(url) ?? new List<ReunionDTO>();

    }

    //historicos
    public async Task<List<ReunionDTO>> GetHistoricos(string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado)
    {
        string f1Formatiado = f1.ToString("yyyy-MM-dd");
        string f2Formatiado = f2.ToString("yyyy-MM-dd");
        url = $"{BaseUrl}/GetHistoricos/{idcentro}/{iddiv}/{f1Formatiado}/{f2Formatiado}/{tipo}/{estado}";
        return reunionditablas = await _http.GetFromJsonAsync<List<ReunionDTO>>(url) ?? new List<ReunionDTO>();

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
                // Consultar nombre del centro y división para retornar el id en pendientes
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
        cliente = _clientFactory.CreateClient();
        mensaje = await cliente.PutAsJsonAsync(url, id);

        try
        {
            string div = "", centro = "";
            if (mensaje.IsSuccessStatusCode)
            {
                band = await mensaje.Content.ReadFromJsonAsync<bool>();
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

    //Obtener id de centro y dic=vision y viceversa

    public async Task<CentroDivisionDTO> GetCentroDiv(string centro, string division, int tipo)
    {
        url = $"{BaseUrl}GetHistoricos/{centro}/{division}/{tipo}";
        return divicent = await _http.GetFromJsonAsync<CentroDivisionDTO>(url) ?? new CentroDivisionDTO();
    }

    //Consultas para los cambios de estatus en una discrepancia
    public async Task<List<CambStatDTO>> GetCambioStatus(int idreu)
    {
        url = $"{BaseUrl}GetCambioStatus/{idreu}";
        return cambiostatus = await _http.GetFromJsonAsync<List<CambStatDTO>>(url) ?? new List<CambStatDTO>();
    }

    public async Task<List<CambFecDTO>> GetCambioFecha(int idreu)
    {
        url = $"{BaseUrl}GetCambioFecha/{idreu}";
        return cambioFecha = await _http.GetFromJsonAsync<List<CambFecDTO>>(url) ?? new List<CambFecDTO>();
    }


    //obtener discrepancia a editar
    public async Task<ReunionDTO> GetDiscrepantacia(int id)
    {
        url = $"{BaseUrl}GetDiscrepantaciaJT/{id}";
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


    public async Task<bool> InsertCambioStatus(CambStatDTO status)
    {
        bool band = false;
        url = $"{BaseUrl}/AddCambioStatus";
        cliente = _clientFactory.CreateClient();
        mensaje = await cliente.PostAsJsonAsync(url, status);

        if (mensaje.IsSuccessStatusCode)
        {
            band = await mensaje.Content.ReadFromJsonAsync<bool>();
        }
        return band;
    }


    public async Task<bool> InsertCambioFec(CambFecDTO cambiofec)
    {
        bool band = false;
        url = $"{BaseUrl}/AddCambioFec";
        cliente = _clientFactory.CreateClient();
        mensaje = await cliente.PostAsJsonAsync(url, cambiofec);

        if (mensaje.IsSuccessStatusCode)
        {
            band = await mensaje.Content.ReadFromJsonAsync<bool>();
        }
        return band;
    }

    public async Task<bool> InsertarRegistros(RegistroCambiosDTO registroCambios)
    {
        bool band = false;
        url = $"{BaseUrl}/AddRegistros";
        cliente = _clientFactory.CreateClient();
        mensaje = await cliente.PostAsJsonAsync(url, registroCambios);

        if (mensaje.IsSuccessStatusCode)
        {
            band = await mensaje.Content.ReadFromJsonAsync<bool>();
        }
        return band;
    }

    public async Task<CentroDivisionDTO> GetCentroDivi(string centro, string division, int tipo)
    {
        url = $"{BaseUrl}GetCentroDivi/{centro}/{division}/{tipo}";
        cliente = _clientFactory.CreateClient();
        return await cliente.GetFromJsonAsync<CentroDivisionDTO>(url) ?? new CentroDivisionDTO();

    }

}



