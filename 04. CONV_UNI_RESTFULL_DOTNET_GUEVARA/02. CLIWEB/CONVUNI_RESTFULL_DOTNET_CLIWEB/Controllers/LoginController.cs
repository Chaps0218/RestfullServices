using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using CONVUNI_RESTFULL_DOTNET_CLIWEB.Models;
using System.Security.Cryptography;

namespace CONVUNI_RESTFULL_DOTNET_CLIWEB.Controllers
{
    public class LoginController : Controller
    {
        private readonly HttpClient _httpClient;

        public LoginController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);

                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var hashedModel = new LoginModel
            {
                username = model.username,
                password = HashPassword(model.password)
            };

            var content = new StringContent(JsonConvert.SerializeObject(hashedModel), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("http://localhost:780/Login", content);
            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<dynamic>(responseData);

                ViewBag.Message = result.message;
                ViewBag.Username = result.username;
                HttpContext.Session.SetString("username", (string)result.username);

                return RedirectToAction("Index", "Conv");
            }
            ViewBag.Message = "Invalid username or password";
            return View("Index");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}
