using System.ComponentModel.DataAnnotations;

namespace ReunionWeb.DTOs
{
    public class UserLoginDto
    {
        [Required(ErrorMessage = "Por favor ingrese el usuario.")]
        public string UserName { get; set; }=string.Empty;

        [Required(ErrorMessage = "Por favor ingrese la contraseña.")]
        public string Password { get; set; }=string.Empty;
        public string Proyecto { get; set; }=string.Empty;

    }
}
