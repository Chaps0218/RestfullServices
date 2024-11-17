﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CONVUNI_RESTFULL_DOTNET_CLIMOV.Models;

namespace CONVUNI_RESTFULL_DOTNET_CLIMOV.Controllers
{
    public class ConvController
    {
        private readonly HttpClient _httpClient;

        public ConvController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> Convertir(ConversionRequest modelRequest)
        {
            var content = new StringContent(JsonConvert.SerializeObject(modelRequest), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("http://192.168.18.8:780/Conv", content);
            if (response.IsSuccessStatusCode)
            {
                var responseData = response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<ConvModel>(responseData);

                return $"Converted Value: {result.resultado} {result.toUnit}";
            }
            else
            {
                return "Conversion failed. Please try again.";
            }
        }
    }
}