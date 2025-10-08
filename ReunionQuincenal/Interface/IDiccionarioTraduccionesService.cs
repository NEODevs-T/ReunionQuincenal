namespace ReunionWeb.Services
{
    public interface IDiccionarioTraduccionesService
    {
        Dictionary<string, string> Traducciones { get; }
        Task CargarTraduccionesAsync();
    }
}
