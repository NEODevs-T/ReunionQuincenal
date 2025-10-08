using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;

public class TokenCultureProvider : RequestCultureProvider
{
    public override Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext)
    {
        var token = httpContext.Request.Headers["Authorization"].ToString();

        if (string.IsNullOrEmpty(token))
            return Task.FromResult<ProviderCultureResult>(null);

        var handler = new JwtSecurityTokenHandler();
        var jwtToken = handler.ReadJwtToken(token.Replace("Bearer ", ""));
        var cultureClaim = jwtToken?.Claims?.FirstOrDefault(c => c.Type.Equals("Culture", StringComparison.OrdinalIgnoreCase))?.Value;


        if (string.IsNullOrEmpty(cultureClaim))
            cultureClaim = "en"; // Por defecto
        System.Diagnostics.Debug.WriteLine($"🌐 Cultura obtenida del token: {cultureClaim}");
        return Task.FromResult(new ProviderCultureResult(cultureClaim));
    }
}
