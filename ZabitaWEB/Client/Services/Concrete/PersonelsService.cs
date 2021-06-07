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
    public class PersonelsService : IPersonelsService
    {
        private readonly HttpClient _httpClient;

        public PersonelsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<IActionResult> DeletePersonel(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Personel>> GetPersonel(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Personel>> GetPersonels()
        {
            return await _httpClient.GetFromJsonAsync<List<Personel>>("/api/Personels");
        }

        public Task<ActionResult<Personel>> PostPersonel(Personel personel)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutPersonel(int id, Personel personel)
        {
            throw new NotImplementedException();
        }
    }
}