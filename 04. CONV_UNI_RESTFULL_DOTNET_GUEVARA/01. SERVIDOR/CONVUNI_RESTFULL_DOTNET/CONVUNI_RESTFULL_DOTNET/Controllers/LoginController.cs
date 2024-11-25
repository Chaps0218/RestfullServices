using Microsoft.AspNetCore.Mvc;
using CONVUNI_RESTFULL_DOTNET.Models;

namespace CONVUNI_RESTFULL_DOTNET.Controllers
{
   [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private static readonly List<LoginModel> users = new List<LoginModel>
        {
            new LoginModel { username = "Monster", password = "7fbdfcdd431cb77a5bce52182f863d807544fdbea2edb49dc396d5ba30481f64" },
            new LoginModel { username = "monster", password = "774e993500f4027acfd72b7a7ee564b76ae43cf7c4c943ed0e0f364cca16b6ec" },
            new LoginModel { username = "admin", password = "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918" }
        };

        [HttpPost]
        public IActionResult Login([FromBody] LoginModel login)
        {
            foreach (var user in users)
            {
                if (user.username == login.username && user.password == login.password)
                {
                    return Ok(new { message = "Login Exitoso", username = user.username });
                }
            }
            return Unauthorized(new { message = "Usuario o Contraseña incorrectos" });
        }
    }
}
