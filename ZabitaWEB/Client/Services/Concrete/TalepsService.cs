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
    public class TalepsService : ITalepsService
    {
        private readonly HttpClient _httpClient;

        public TalepsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task<IActionResult> DeleteTalep(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Talep>> GetTalep(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<Talep>>> GetTaleps()
        {
            return await _httpClient.GetFromJsonAsync<List<Talep>>("/api/Taleps");
        }

        public Task<ActionResult<Talep>> PostTalep(Talep talep)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutTalep(int id, Talep talep)
        {
            throw new NotImplementedException();
        }
    }
}
