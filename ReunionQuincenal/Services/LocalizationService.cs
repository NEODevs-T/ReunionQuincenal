using System.Globalization;
using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace ReunionWeb.Services
{
    public class LocalizationService
    {
        private readonly AuthenticationStateProvider _authStateProvider;

        public LocalizationService(AuthenticationStateProvider authStateProvider)
        {
            _authStateProvider = authStateProvider;
        }

        public async Task EstablecerCulturaDesdeTokenAsync()
        {
            try
            {
                var authState = await _authStateProvider.GetAuthenticationStateAsync();
                var user = authState.User;

                if (user.Identity is not null && user.Identity.IsAuthenticated)
                {
                    var cultureClaim = user.FindFirst(c => c.Type == "Culture")?.Value ?? "es";

                    // Validar si la cultura es válida
                    var culture = CultureInfo.GetCultures(CultureTypes.AllCultures)
                                             .FirstOrDefault(c => c.Name == cultureClaim) ?? new CultureInfo("es");

                    // Aplicar cultura globalmente
                    CultureInfo.CurrentCulture = culture;
                    CultureInfo.CurrentUICulture = culture;
                    CultureInfo.DefaultThreadCurrentCulture = culture;
                    CultureInfo.DefaultThreadCurrentUICulture = culture;

                    Console.WriteLine($"🌐 Cultura establecida desde Claim: {culture.Name}");
                }
                else
                {
                    Console.WriteLine("⚠️ Usuario no autenticado. No se puede establecer la cultura.");
                }
            }
            catch (CultureNotFoundException ex)
            {
                Console.WriteLine($"❌ Cultura no válida en el token: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error al establecer la cultura: {ex.Message}");
            }
        }
    }
}