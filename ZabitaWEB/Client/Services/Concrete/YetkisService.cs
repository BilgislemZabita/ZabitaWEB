using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;
using ZabitaWEB.Client.Services.Abstract;

namespace ZabitaWEB.Client.Services.Concrete
{
    public class YetkisService : IYetkisService
    {
        private readonly HttpClient _httpClient;

        public YetkisService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<IActionResult> DeleteYetki(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Yetki>> GetYetki(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Yetki>> GetYetkis()
        {
            return await _httpClient.GetFromJsonAsync<List<Yetki>>("/api/Yetkis");
        }

        public async Task<Uri> PostYetki(Yetki yetki)
        {
            //var stringContent = new StringContent(yetki.ToString());
            //var response = await _httpClient.PostAsync("/api/Yetkis", stringContent);
            var response = await _httpClient.PostAsJsonAsync<ActionResult<Yetki>>("/api/Yetkis", yetki);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }

        public Task<IActionResult> PutYetki(int id, Yetki yetki)
        {
            throw new NotImplementedException();
        }
    }
}