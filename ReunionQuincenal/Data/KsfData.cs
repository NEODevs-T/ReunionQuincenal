    using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;


using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;
using ReunionWeb.Interface;

namespace ReunionWeb.Data;

public class KsfData: IKsfData
{

    public KsfData(IHttpClientFactory clientFactory, HttpClient http, NavigationManager navigationManager)
    {
        _http = http;

        _clientFactory = clientFactory;

    }

    private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/Ksf";
    private HttpClient cliente { get; set; } = new HttpClient();
    private HttpClient _http { get; set; } = new HttpClient();
    private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
    private string url { get; set; } = "";
    private readonly IHttpClientFactory _clientFactory;
    
    public List<KsfDTO> ksfs { get; set; } = new List<KsfDTO>();
    
    
    public async Task<List<KsfDTO>> Getksf()
    {
        url = $"{BaseUrl}/GetKsf";
        cliente = _clientFactory.CreateClient();
        ksfs = await _http.GetFromJsonAsync<List<KsfDTO>>(url);
        var results = ksfs;
        return results;
    }
}