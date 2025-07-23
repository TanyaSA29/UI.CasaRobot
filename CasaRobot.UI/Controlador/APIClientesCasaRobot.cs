using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Controlador
{
    public class APIClientesCasaRobot
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseurl;

        public APIClientesCasaRobot(string baseurl)
        {
            _baseurl = baseurl.TrimEnd('/');
            _httpClient = new HttpClient();
        }
        public async Task<T> GetAsync<T>(string endpoint)
        {
            var respuesta = await _httpClient.GetAsync($"{_baseurl}/{endpoint}");
            respuesta.EnsureSuccessStatusCode();
            

            var contenido=  await respuesta.Content.ReadAsStringAsync();
            return JsonConvert .DeserializeObject<T>(contenido);
        }

        public async Task<T> PostAsync<T>(string endpoint, object data)
        {
            var contenido = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            var respuesta = await _httpClient.PostAsync($"{_baseurl}/{endpoint}", contenido);
            respuesta.EnsureSuccessStatusCode();
            var responseContent = await respuesta.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseContent);
        }
    }
}
