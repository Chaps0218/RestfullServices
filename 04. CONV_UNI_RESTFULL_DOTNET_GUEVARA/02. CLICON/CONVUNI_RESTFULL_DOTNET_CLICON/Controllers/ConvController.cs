using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONVUNI_RESTFULL_DOTNET_CLICON.Models;
using Newtonsoft.Json;

namespace CONVUNI_RESTFULL_DOTNET_CLICON.Controllers
{
    public class ConvController
    {
        private readonly HttpClient _httpClient;

        public ConvController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> Convertir(ConversionRequest modelRequest) {
            var content = new StringContent(JsonConvert.SerializeObject(modelRequest), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("http://localhost:780/Conv", content);
            if (response.IsSuccessStatusCode)
            {
                var responseData = response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<ConvModel>(responseData);

                return $"Valor Convertido: {result.resultado} {result.toUnit}";
            }
            else
            {
                return "Ocurrió un error. Por favor, inténtelo de nuevo";
            }
        }
    }
}
