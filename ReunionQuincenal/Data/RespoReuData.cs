using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;


using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;
using ReunionWeb.Interface;

namespace ReunionWeb.Data;

    public class RespoReuData :IRespoReuData
{

    public RespoReuData(IHttpClientFactory clientFactory, HttpClient http)
    {
        _http = http;

        _clientFactory = clientFactory;

    }

    private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/RespoReunion";
    private HttpClient cliente { get; set; } = new HttpClient();
    private HttpClient _http { get; set; } = new HttpClient();
    private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
    private string url { get; set; } = "";
    private readonly IHttpClientFactory _clientFactory;

    public List<RespoReuDTO> resporeus { get; set; } = new List<RespoReuDTO>();
    
    
    public async Task<List<RespoReuDTO>> GetResReu()
    {
        url = $"{BaseUrl}/GetResponsables";
        cliente = _clientFactory.CreateClient();
        resporeus = await _http.GetFromJsonAsync<List<RespoReuDTO>>($"{BaseUrl}/GetResponsables");
        return await cliente.GetFromJsonAsync<List<RespoReuDTO>>(url) ?? new List<RespoReuDTO>();
    }
}