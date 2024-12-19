using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;


using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;

namespace ReunionWeb.Services;
public class APIReunionService : IAPIReunionService
{
        // **-------> CONEXION A LA API <--------**
        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrlMaestra = "http://neo.paveca.com.ve/apineomaster/api/Maestra";
        private const string BaseUrlLineas = "http://neo.paveca.com.ve/apineomaster/api/Lineas";
        private const string BaseUrl = "http://localhost:5021/api/Maestra";
        private const string ViejaUrl1 = "http://neo.paveca.com.ve/ReunionApi/Lineas";
        private const string ViejaUrl2 = "http://neo.paveca.com.ve/ReunionApi/Empresas";
        private HttpClient cliente { get; set; } = new HttpClient();
        private HttpClient _http { get; set; } = new HttpClient();
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url { get; set; } = "";

        public APIReunionService(IHttpClientFactory clientFactory, HttpClient http)
        {
                _clientFactory = clientFactory;
                _http = http;
        }

        // **-------> CONEXION A LA API <--------**


        // **-------> PROPIEDADES DE JAVIER <------**
        public List<MaestraVDTO> centro { get; set; } = new List<MaestraVDTO>();
        public List<LineaVDTO> lineas { get; set; } = new List<LineaVDTO>();
        public List<DivisionesVDTO> divisions { get; set; } = new List<DivisionesVDTO>();
        public List<KsfDTO> ksfs { get; set; } = new List<KsfDTO>();
        public List<RespoReuDTO> resporeu { get; set; } = new List<RespoReuDTO>();
        public List<ReunionDTO> reunionditabla { get; set; } = new List<ReunionDTO>();
        public List<ReunionDTO> reudiatabla { get; set; } = new List<ReunionDTO>();
        public List<AsistenReuDTO> asistenreus { get; set; } = new List<AsistenReuDTO>();
        public List<CargoReuDTO> cargoreus { get; set; } = new List<CargoReuDTO>();
        public List<StatsAsisDto> StatsAsisDtos { get; set; } = new List<StatsAsisDto>();
        public List<EquipoEamDTO> equipos { get; set; } = new List<EquipoEamDTO>();
        public List<EquipoEamDTO> equiposlinea { get; set; } = new List<EquipoEamDTO>();
        public List<CalendarioTrabajoDTO> calentrabajo { get; set; } = new List<CalendarioTrabajoDTO>();

        public RegistroCambiosDTO listaRegistro { get; set; } //= new RegistroCambiosDTO(); 


        // **-------> PROPIEDADES DE JAVIER <------**


        public async Task<List<EquipoEamDTO>> GetEquiposEAM(string cent)
        {

                // url = $"{BaseUrlLineas}/GetEquipos/{cent}";
                url = $"{BaseUrlLineas}/GetEquipos/{cent}";
                cliente = _clientFactory.CreateClient();
                equipos = await _http.GetFromJsonAsync<List<EquipoEamDTO>>($"{BaseUrlLineas}/GetEquipos/{cent}");
                return await cliente.GetFromJsonAsync<List<EquipoEamDTO>>(url) ?? new List<EquipoEamDTO>();

        }
        public async Task<List<EquipoEamDTO>> GetEquiposID(string idCentro)
        {
                url = $"{BaseUrlMaestra}/GetEquipos/{idCentro}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<EquipoEamDTO>>(url) ?? new List<EquipoEamDTO>();

        }
        public async Task<List<EquipoEamDTO>> GetEquiposxlinea(string idLinea)
        {
                url = $"{BaseUrlMaestra}/GetEquiposEAMPorLinea/{idLinea}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<EquipoEamDTO>>(url) ?? new List<EquipoEamDTO>();

        }
        //TODO: AREGLAR METODO
        public async Task<List<DivisionesVDTO>> GetBdDiv(string cent)
        {

                url = $"{BaseUrlLineas}/GetBdDiv/{cent}";
                return divisions = await _http.GetFromJsonAsync<List<DivisionesVDTO>>(url) ?? new List<DivisionesVDTO>();
        }

        public async Task<List<DivisionesVDTO>> ObtenerDivisionDelCentro(int idCentro)
        {
                url = $"{BaseUrlMaestra}/GetDivisiones/{idCentro}";
                return divisions = await _http.GetFromJsonAsync<List<DivisionesVDTO>>(url) ?? new List<DivisionesVDTO>();
        }

        public async Task<List<MaestraVDTO>> GetCentrosxEmpresa(string cent)
        {
                url = $"{BaseUrlMaestra}/GetCentrosJT/{cent}";
                // url = $"{BaseUrl}/GetCentrosJT/{cent}";
                cliente = _clientFactory.CreateClient();
                return centro = await _http.GetFromJsonAsync<List<MaestraVDTO>>(url) ?? new List<MaestraVDTO>();
        }

        public async Task<List<LineaVDTO>> ObtenerLasLineasPorDivision(int idDivision)
        {
                url = $"{BaseUrlMaestra}/GetLineas/{idDivision}";
                return lineas = await _http.GetFromJsonAsync<List<LineaVDTO>>(url) ?? new List<LineaVDTO>();
        }


        // public async Task GetDivision(string centro, string div)
        // {
        //     var result = await _http.GetFromJsonAsync<List<Division>>($"http://neo.paveca.com.ve/ReunionApi/Lineas/Division/{centro}/{div}");
        //     //var result = await _http.GetFromJsonAsync<List<Division>>($"http://localhost:5258/Lineas/Division/{centro}/{div}");
        //     if (result != null)
        //         divisions = result;
        // //}



        public async Task<List<LineaVDTO>> GetLineas(int idDivision)
        {
                url = $"{BaseUrlMaestra}/GetLineas/{idDivision:int}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<LineaVDTO>>(url) ?? new List<LineaVDTO>();
        }


        public async Task<List<KsfDTO>> Getksf()
        {
                url = $"{BaseUrlLineas}/GetKsf";
                cliente = _clientFactory.CreateClient();
                ksfs = await _http.GetFromJsonAsync<List<KsfDTO>>($"{BaseUrlLineas}/GetKsf");
                var results = await cliente.GetFromJsonAsync<List<KsfDTO>>(url);
                return results;
                // return await cliente.GetFromJsonAsync<List<KsfDTO>>(url) ?? new List<KsfDTO>();
        }

        public async Task<List<RespoReuDTO>> GetResReu()
        {
                url = $"{BaseUrlLineas}/GetResponsables";
                cliente = _clientFactory.CreateClient();
                resporeu = await _http.GetFromJsonAsync<List<RespoReuDTO>>($"{BaseUrlLineas}/GetResponsables");
                return await cliente.GetFromJsonAsync<List<RespoReuDTO>>(url) ?? new List<RespoReuDTO>();
        }


        public async Task<List<CargoReuDTO>> GetAsistencia(string div, string empresa)
        {
                url = $"{BaseUrlLineas}/GetAsistencia/{div}/{empresa}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<CargoReuDTO>>(url) ?? new List<CargoReuDTO>();
        }
        public async Task<List<AsistenReuDTO>> GetStatsAsist(string div, string empresa, string f1, string f2)
        {
                url = $"{BaseUrlMaestra}/GetStatsAsis/{div}/{empresa}/{f1}/{f2}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<AsistenReuDTO>>(url) ?? new List<AsistenReuDTO>();
        }

        public async Task<List<AsistenReuDTO>> GetListaAsist(string div, string empresa, string f1, string f2)
        {
                url = $"{BaseUrlMaestra}/GetListaAsis/{div}/{empresa}/{f1}/{f2}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<AsistenReuDTO>>(url) ?? new List<AsistenReuDTO>();
        }

        public async Task<string> Postasistencia(List<AsistenReuDTO> asisten)
        {
                string mens = "";
                url = $"{BaseUrlLineas}/AddAsistencia";
                cliente = _clientFactory.CreateClient();
                mensaje = await cliente.PostAsJsonAsync(url, asisten);
                if (mensaje.IsSuccessStatusCode)
                {
                        mens = "Se añadido exitosamente";
                }
                return mens;
        }
        public async Task<string> AddEquipo(EquipoDTO equipo)
        {
                string mens = "";
                url = $"{BaseUrlMaestra}/AddEquipo";
                cliente = _clientFactory.CreateClient();
                mensaje = await cliente.PostAsJsonAsync(url, equipo);
                if (mensaje.IsSuccessStatusCode)
                {
                        mens = "Se añadido exitosamente";
                }
                return mens;
        }

        public async Task<List<ReunionDTO>> GetTrabajosCalendario(string pais, string centro, string division)
        {
                url = $"{BaseUrlMaestra}/GetTrabajosPorCalendario/{pais}/{centro}/{division}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<ReunionDTO>>(url) ?? new List<ReunionDTO>();
        }

        public async Task<List<EquipoEamDTO>> GetEquiposCentro(string idCentro)
        {
                url = $"{BaseUrlMaestra}/GetEquipos/{idCentro}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<EquipoEamDTO>>(url) ?? new List<EquipoEamDTO>();
        }




        ////Version local**********************************************************************************************************************
        ////Conversion
        //public async Task GetEquiposEAM(string cent)
        //{
        //    var result = await _http.GetFromJsonAsync<List<EquipoEam>>($"http://localhost:5258/Lineas/Equipos/{cent}");
        //    if (result != null)
        //        equipos = result;

        //}
        //public async Task GetEquiposID(string cent)
        //{

        //    var result = await _http.GetFromJsonAsync<List<EquipoEam>>($"http://localhost:5258/Empresas/Equipos/{cent}");
        //    if (result != null)
        //        equipos = result;

        //}
        //public async Task GetEquiposxlinea(string linea)
        //{
        //    var result = await _http.GetFromJsonAsync<List<EquipoEam>>($"http://localhost:5258/Empresas/EquiposLinea/{linea}");
        //    if (result != null)
        //        equiposlinea = result;

        //}

        //public async Task GetCentros(string cent)
        //{
        //    var result = await _http.GetFromJsonAsync<List<Centro>>($"http://localhost:5258/Lineas/{cent}");
        //    if (result != null)
        //        centro = result;

        //}

        //public async Task GetCentrosxEmpresa(string cent)
        //{
        //    var result = await _http.GetFromJsonAsync<List<Centro>>($"http://localhost:5258/Empresas/Centros/{cent}");
        //    if (result != null)
        //        centro = result;

        //}
        //public async Task GetDivision(string centro, string div)
        //{
        //    var result = await _http.GetFromJsonAsync<List<Division>>($"http://localhost:5258/Lineas/Division/{centro}/{div}");
        //    if (result != null)
        //        divisions = result;

        //}
        //public async Task GetLineas(int div)
        //{
        //    var result = await _http.GetFromJsonAsync<List<Linea>>($"http://localhost:5258/Empresas/Lineas/{div}");
        //    if (result != null)
        //        lineas = result;

        //}
        //public async Task Getksf()
        //{
        //    var result = await _http.GetFromJsonAsync<List<Ksf>>($"http://localhost:5258/Lineas/Ksf");
        //    if (result != null)
        //        ksfs = result;

        //}
        //public async Task GetResReu()
        //{
        //    var result = await _http.GetFromJsonAsync<List<RespoReu>>($"http://localhost:5258/Lineas/Responsables");
        //    if (result != null)
        //        resporeu = result;

        //}





        //public async Task GetAsistencia(string div, string empresa)
        //{

        //    var result = await _http.GetFromJsonAsync<List<CargoReu>>($"http://localhost:5258/Lineas/Asistencia/{div}/{empresa}");
        //    if (result != null)
        //        cargoreus = result;

        //}
        //public async Task GetStatsAsist(string div, string empresa, string f1, string f2)
        //{


        //    var result = await _http.GetFromJsonAsync<List<StatsAsisDto>>($"http://localhost:5258/ReunionApi/Lineas/StatsAsis/{div}/{empresa}/{f1}/{f2}");
        //    // var result = await _http.GetFromJsonAsync<List<StatsAsisDto>>($"http://operaciones.papeleslatinos.com/ReunionApi/Lineas/StatsAsis/{div}/{f1}/{f2}");
        //    if (result != null)
        //        StatsAsisDtos = result;
        //}
        //public async Task GetListaAsist(string div, string empresa, string f1, string f2)
        //{

        //    var result = await _http.GetFromJsonAsync<List<AsistenReu>>($"http://localhost:5258/ReunionApi/Lineas/ListaAsis/{div}/{empresa}/{f1}/{f2}");
        //    if (result != null)
        //        asistenreus = result;
        //}




        //public async Task<string> Postasistencia(List<AsistenReu> asisten)
        //{

        //    var result = await _http.PostAsJsonAsync("http://localhost:5258/Lineas/Asistencia", asisten);
        //    var msj = await result.Content.ReadAsStringAsync();
        //    return msj;
        //}
        //public async Task<string> PostEquipo(EquipoDTO equipo)
        //{

        //    var result = await _http.PostAsJsonAsync("http://localhost:5258/Empresas/AddEquipo", equipo);
        //    var msj = await result.Content.ReadAsStringAsync();
        //    return msj;
        //}
}

