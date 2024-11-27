using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Security.Cryptography;
using CONVUNI_RESTFULL_DOTNET_CLIMOV.Models;

namespace CONVUNI_RESTFULL_DOTNET_CLIMOV.Controllers
{
    public class LoginController
    {
        private readonly HttpClient _httpClient;

        public LoginController()
        {
            _httpClient = new HttpClient();
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

        public async Task<bool> Login(LoginModel model)
        {
            var hashedModel = new LoginModel
            {
                username = model.username,
                password = HashPassword(model.password)
            };

            var content = new StringContent(JsonConvert.SerializeObject(hashedModel), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("http://10.40.28.156:780/Login", content);
            if (response.IsSuccessStatusCode)
            {
                var responseData = response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<dynamic>(responseData);

                return true;
            }
            return false;
        }
    }
}
