using System.Globalization;

namespace ReunionWeb.Services
{
    public class CultureService
    {
        public CultureInfo UserCulture { get; private set; } = new CultureInfo("es");

        public void SetCulture(string cultureName)
        {
            if (!string.IsNullOrWhiteSpace(cultureName))
            {
                UserCulture = new CultureInfo(cultureName);
            }
        }

        public string GetCultureName()
        {
            return UserCulture.Name;
        }
    }
}
