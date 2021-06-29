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
    public class DemirbasService : IDemirbasService
    {
        private readonly HttpClient _httpClient;

        public DemirbasService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<ActionResult<bool>> DeleteDemirbas(int id)
        {
            var deleteTask = await _httpClient.DeleteAsync("Demirbas/" + id.ToString());
            return true;

        }

        public Task<ActionResult<Demirbas>> GetDemirbas(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Demirbas>> GetDemirbases()
        {
            return await _httpClient.GetFromJsonAsync<List<Demirbas>>("/api/Demirbas");
        }

        public async Task<Uri> PostDemirbas(Demirbas demirbas)
        {
            var response = await _httpClient.PostAsJsonAsync<Demirbas>("/api/Demirbas", demirbas);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }

        public Task<IActionResult> PutDemirbas(int id, Demirbas demirbas)
        {
            throw new NotImplementedException();
        }
    }
}