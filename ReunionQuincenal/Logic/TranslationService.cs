using System.Globalization;
using ReunionWeb.Resources;

namespace ReunionWeb.Services
{
    public class TranslationService : ITranslationService
    {
        public string Traducir(string clave)
        {
            var traduccion = ValidationMessages.ResourceManager.GetString(clave, CultureInfo.CurrentUICulture);
            return string.IsNullOrEmpty(traduccion) ? clave : traduccion;
        }
    }
}