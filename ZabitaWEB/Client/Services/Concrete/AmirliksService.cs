using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;
using ZabitaWEB.Client.Services.Abstract;

namespace ZabitaWEB.Client.Services.Concrete
{
    public class AmirliksService : IAmirliksService
    {
        private readonly HttpClient _httpClient;

        public AmirliksService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ActionResult<bool>> DeleteAmirlik(int id)
        {
            
            await _httpClient.DeleteAsync("/api/Amirliks/" + id.ToString());
            return true;
        }

        public async Task<ActionResult<Amirlik>> GetAmirlik(int id) //Kontrol Edilmedi
        {
            return await _httpClient.GetFromJsonAsync<Amirlik>("/api/Amirliks/" + id.ToString());
        }
          public async Task<Amirlik> GetAmirlikonly(int id) //Kontrol Edilmedi
        {
            return await _httpClient.GetFromJsonAsync<Amirlik>("/api/Amirliks/" + id.ToString());
        }

        public async Task<List<Amirlik>> GetAmirliks()
        {
            return await _httpClient.GetFromJsonAsync<List<Amirlik>>("/api/Amirliks");
        }

        public async Task<Uri> PostAmirlik(Amirlik amirlik)
        {
            var response = await _httpClient.PostAsJsonAsync<Amirlik>("/api/Amirliks", amirlik);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }

        public async Task<ActionResult<bool>> PutAmirlik(int id, Amirlik amirlik) //Çalışmıyor 
        {
            await _httpClient.PutAsJsonAsync<Amirlik>("/api/Amirliks/" + id.ToString(),amirlik);
            return true;
        }
    }
}