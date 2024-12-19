using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;


using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;
using ReunionWeb.Interface;


namespace ReunionWeb.Data;

public class AvisadorData: IAvisadorData
{
    public AvisadorData(NavigationManager navigationManager, IHttpClientFactory clientFactory, HttpClient http)
    {
        _clientFactory = clientFactory;
        _http = http;
        _navigationManager = navigationManager;
    }

    private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/Avisador";
    private const string BaseUrl2 = "http://localhost:5021/api/Avisador";

    private readonly IHttpClientFactory _clientFactory;
    private HttpClient cliente { get; set; } = new HttpClient();
    private HttpClient _http { get; set; } = new HttpClient();
    private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
    private string url { get; set; } = "";
    public List<CambStatDTO> cambiostatus { get; set; } = new List<CambStatDTO>();
    public List<CambFecDTO> cambiofecha { get; set; } = new List<CambFecDTO>();
    public RegistroCambiosDTO listaRegistro { get; set; }
    List<CambiReuVDTO> listaCambiReu { get; set; } = new List<CambiReuVDTO>();

    private readonly NavigationManager _navigationManager;


    public async Task<List<CambStatDTO>> GetCambioStatus(int idreu)
    {
        url = $"{BaseUrl}/GetCambioStatus/{idreu}";
        return cambiostatus = await _http.GetFromJsonAsync<List<CambStatDTO>>(url) ?? new List<CambStatDTO>();
    }


    public async Task<List<CambFecDTO>> GetCambioFecha(int idreu)
    {
        url = $"{BaseUrl}/GetCambioFecha/{idreu}";
        return cambiofecha = await _http.GetFromJsonAsync<List<CambFecDTO>>(url) ?? new List<CambFecDTO>();
    }

    Task<List<CambiReuVDTO>> GetPendientesQuincenal2(string idcentro, string iddiv){

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
        url = $"{BaseUrl}/AddRegistrosCambios";
        cliente = _clientFactory.CreateClient();
        mensaje = await cliente.PostAsJsonAsync(url, registroCambios);

        if (mensaje.IsSuccessStatusCode)
        {
            band = await mensaje.Content.ReadFromJsonAsync<bool>();
        }
        return band;
    }


}