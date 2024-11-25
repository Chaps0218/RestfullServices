using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using CONVUNI_RESTFULL_DOTNET_CLIWEB.Models;

namespace CONVUNI_RESTFULL_DOTNET_CLIWEB.Controllers
{
    public class ConvController : Controller
    {
        private readonly HttpClient _httpClient;

        public ConvController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Username = HttpContext.Session.GetString("username");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Convertir(ConversionRequest request)
        {
            var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("http://localhost:780/Conv", content);
            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ConvModel>(responseData);

                ViewBag.Result = $"Valor Convertido: {result.resultado} {request.ToUnit}";
                return View("Index");
            }
            ViewBag.Error = "Conversión fallida. Inténtelo nuevamente.";
            return View("Index");
        }
    }
}
