using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRobot.UI.Controlador
{
    public class APIClienteCasaRobot
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseurl;

        public APIClienteCasaRobot(string baseurl)
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


    }
}
