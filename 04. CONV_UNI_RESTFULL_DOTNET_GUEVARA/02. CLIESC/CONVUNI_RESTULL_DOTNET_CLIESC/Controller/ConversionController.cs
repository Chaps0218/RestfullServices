using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONVUNI_RESTULL_DOTNET_CLIESC.Model;

namespace CONVUNI_RESTULL_DOTNET_CLIESC.Controller
{
    public class ConversionController
    {
        private readonly HttpClient _httpClient;

        public ConversionController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> Convertir(ConversionRequest modelRequest)
        {
            var content = new StringContent(JsonConvert.SerializeObject(modelRequest), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("http://10.40.27.186:780/Conv", content);
            if (response.IsSuccessStatusCode)
            {
                var responseData = response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<ConversionModel>(responseData);

                return $"Valor Convertido: {result.resultado} {result.toUnit}";
            }
            else
            {
                return "Ocurrió un error. Por favor, inténtelo de nuevo";
            }
        }

    }
}
