using System.ComponentModel.DataAnnotations;
using ReunionWeb.Resources;

namespace ReunionWeb.DTOs
{
    public class UserLoginDto
    {
        
        [Required(
        ErrorMessageResourceType = typeof(ValidationMessages),
        ErrorMessageResourceName = "RequiredUserName")]

        public string UserName { get; set; }=string.Empty;

        
        [Required(
        ErrorMessageResourceType = typeof(ValidationMessages),
        ErrorMessageResourceName = "RequiredPassword")]

        public string Password { get; set; }=string.Empty;
        public string Proyecto { get; set; }=string.Empty;

    }
}
