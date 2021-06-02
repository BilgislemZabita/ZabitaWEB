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

        public Task<IActionResult> DeleteAmirlik(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Amirlik>> GetAmirlik(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Amirlik>> GetAmirliks()
        {
            return await _httpClient.GetFromJsonAsync<List<Amirlik>>("/api/Amirliks");
        }

        public Task<ActionResult<Amirlik>> PostAmirlik(Amirlik amirlik)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutAmirlik(int id, Amirlik amirlik)
        {
            throw new NotImplementedException();
        }
    }
}