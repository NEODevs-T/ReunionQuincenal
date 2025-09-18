public class Usuario
{
    public int idPais { get; set; }
    public string CultureName => idPais == 5 ? "en" : "es";
}

public class UsuarioContexto
{
    private readonly AuthenticationStateProvider _authStateProvider;

    public UsuarioContexto(AuthenticationStateProvider authStateProvider)
    {
        _authStateProvider = authStateProvider;
    }

    public async Task<Usuario?> ObtenerUsuarioActualAsync()
    {
        var authState = await _authStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if (user.Identity?.IsAuthenticated ?? false)
        {
            var idPaisClaim = user.FindFirst("idPais")?.Value;

            if (int.TryParse(idPaisClaim, out int idPais))
            {
                return new Usuario
                {
                    idPais = idPais
                };
            }
        }

        return null;
    }
}
