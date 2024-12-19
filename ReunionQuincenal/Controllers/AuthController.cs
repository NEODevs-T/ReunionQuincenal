using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.DTOs;

namespace ReunionWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        [HttpPost]
        public async Task<ActionResult<string>> Loging(UserLoginDto request)
        {
            string token = @"Prueba";
            return token;
        }
    }
}
