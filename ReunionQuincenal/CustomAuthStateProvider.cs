using System.Security.Claims;
using System.Text.Json;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using ReunionWeb.Services;
using ReunionWeb.DTOs;

namespace ReunionWeb
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorage;
        private readonly ProtectedLocalStorage _DataLocal;
        private readonly HttpClient _http;
       

   

        public CustomAuthStateProvider(ILocalStorageService localStorage, HttpClient http, ProtectedLocalStorage DataLocal)
        {
            _localStorage = localStorage;
            _http = http;
            _DataLocal = DataLocal;
        }


        public override async  Task<AuthenticationState>  GetAuthenticationStateAsync()
        {
           string token = await _localStorage.GetItemAsStringAsync("ReunionWebToken");
           

            var identity = new ClaimsIdentity();
            _http.DefaultRequestHeaders.Authorization = null;

            if (!string.IsNullOrEmpty(token))
            {
                identity = new ClaimsIdentity(ParseClaimsFromJwt(token), "jwt");
                _http.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", token.Replace("\"", ""));
            }

            var user = new ClaimsPrincipal(identity);
            var state = new AuthenticationState(user);

            NotifyAuthenticationStateChanged(Task.FromResult(state));
            return state;

        }

        public static IEnumerable<Claim>ParseClaimsFromJwt(string jwt)
        {
            var payload = jwt.Split('.')[1];
            var jsonBytes=ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);
            return keyValuePairs.Select(KeyValuePair => new Claim(KeyValuePair.Key, KeyValuePair.Value.ToString()));
        }
        private static byte[] ParseBase64WithoutPadding(string base64)
        {
            switch(base64.Length % 4)
            {
                case 2: base64 +="=="; break;
                case 3: base64 +="="; break;
            }
            return Convert.FromBase64String(base64);
        }

    }
}
