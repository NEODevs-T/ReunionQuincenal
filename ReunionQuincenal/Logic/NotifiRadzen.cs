using Radzen;

namespace ReunionWeb.Logic
{
    public class NotifiRadzen
    {
        public NotificationMessage Notificacion(string tipo, string mensaje, string detalle)
        {


            NotificationMessage notificacion = new NotificationMessage { };
            if (tipo == "error")
            {
                notificacion = new NotificationMessage { Severity = NotificationSeverity.Error, Summary = mensaje, Detail = detalle, Duration = 8000 };
            }
            else if (tipo == "info")
            {
                notificacion = new NotificationMessage { Severity = NotificationSeverity.Info, Summary = mensaje, Detail = detalle, Duration = 8000 };
            }
            else if (tipo == "exito")
            {
                notificacion = new NotificationMessage { Severity = NotificationSeverity.Success, Summary = mensaje, Detail = detalle, Duration = 8000 };
            }
            else if (tipo == "advertencia")
            {
                notificacion = new NotificationMessage { Severity = NotificationSeverity.Warning, Summary = mensaje, Detail = detalle, Duration = 8000 };
            }
            return (notificacion);
        }
    }
}
