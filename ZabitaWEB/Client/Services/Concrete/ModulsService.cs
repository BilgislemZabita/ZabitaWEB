using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;

using System.Threading.Tasks;
using Zabita.Entities.Concrete;
using ZabitaWEB.Client.Services.Abstract;

namespace ZabitaWEB.Client.Services.Concrete
{
    public class ModulsService : IModulsService
    {
        private readonly HttpClient _httpClient;

        public ModulsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<IActionResult> DeleteModul(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Modul>> GetModul(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Modul>> GetModuls()
        {
            return await _httpClient.GetFromJsonAsync<List<Modul>>("/api/Moduls");
        }

        public Task<ActionResult<Modul>> PostModul(Modul modul)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutModul(int id, Modul modul)
        {
            throw new NotImplementedException();
        }
    }
}