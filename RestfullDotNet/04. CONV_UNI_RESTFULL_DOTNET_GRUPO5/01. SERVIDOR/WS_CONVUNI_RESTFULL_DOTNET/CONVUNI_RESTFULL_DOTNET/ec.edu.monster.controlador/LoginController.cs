using Microsoft.AspNetCore.Mvc;
using CONVUNI_RESTFULL_DOTNET.ec.edu.monster.modelo;

namespace CONVUNI_RESTFULL_DOTNET.ec.edu.monster.controlador
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        public LoginModelo[] users = [
                new LoginModelo { username = "Monster", password = "7fbdfcdd431cb77a5bce52182f863d807544fdbea2edb49dc396d5ba30481f64" },
                new LoginModelo { username = "monster", password = "774e993500f4027acfd72b7a7ee564b76ae43cf7c4c943ed0e0f364cca16b6ec" },
                new LoginModelo { username = "admin", password = "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918" }
            ];

        [HttpPost]
        public ActionResult<LoginModelo> Login(string username, string password)
        {
            foreach (LoginModelo user in users)
            {
                if (user.username == username && user.password == password)
                {
                    return user;
                }
            }
            return new LoginModelo();
        }
    }
}
