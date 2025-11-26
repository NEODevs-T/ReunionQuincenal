using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;


using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;
using ReunionWeb.Interface;

namespace ReunionWeb.Data;

public class CargoReuData : ICargoReuData
{

    public CargoReuData(IHttpClientFactory clientFactory, HttpClient http, NavigationManager navigationManager)
    {
        _http = http;

        _clientFactory = clientFactory;

    }

    private const string BaseUrl = "http://neo.grandbay-corp.com/ApiNeoMasterP/api/CargoReu";
    private HttpClient cliente { get; set; } = new HttpClient();
    private HttpClient _http { get; set; } = new HttpClient();
    private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
    private string url { get; set; } = "";
    private readonly IHttpClientFactory _clientFactory;
    public List<CargoReuDTO> cargoreuss { get; set; } = new List<CargoReuDTO>();
    public List<CarReuDTO> carreus { get; set; } = new List<CarReuDTO>();
    


    public async Task<List<CargoReuDTO>> GetAsistenciaQuincenal(string div, string empresa)
    {
        url = $"{BaseUrl}/GetAsistenciaQuincenal/{div}/{empresa}";
        cliente = _clientFactory.CreateClient();
        return cargoreuss = await cliente.GetFromJsonAsync<List<CargoReuDTO>>(url) ?? new List<CargoReuDTO>();
    }

    public async Task<List<CarReuDTO>> GetCargosReunion()
    {
        return await _http.GetFromJsonAsync<List<CarReuDTO>>("http://neo.grandbay-corp.com/ApiNeoMasterP/api/AsistenciaReu/GetCargoReuDiaria");
    }

}