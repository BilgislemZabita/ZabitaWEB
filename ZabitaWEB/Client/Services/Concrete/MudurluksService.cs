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
    public class MudurluksService : IMudurluksService
    {
        private readonly HttpClient _httpClient;
        public MudurluksService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task<IActionResult> DeleteMudurluk(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Mudurluk>> GetMudurluk(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Mudurluk>> GetMudurluks()
        {
            return await _httpClient.GetFromJsonAsync<List<Mudurluk>>("/api/Mudurluks");
        }

        public Task<ActionResult<Mudurluk>> PostMudurluk(Mudurluk mudurluk)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutMudurluk(int id, Mudurluk mudurluk)
        {
            throw new NotImplementedException();
        }
    }
}