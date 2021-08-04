using Microsoft.AspNetCore.Http;
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
    public class YerleskeBakimOnarimsService : IYerleskeBakimOnarimsService
    {
        private readonly HttpClient _httpClient;

    
        public YerleskeBakimOnarimsService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }
        public Task<IActionResult> DeleteYerleskeBakimOnarim(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<YerleskeBakimOnarim>> GetYerleskeBakimOnarim(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<YerleskeBakimOnarim>>> GetYerleskeBakimOnarims()
        {
            throw new NotImplementedException();
        }

        public async Task<StatusCodeResult> PostYerleskeBakimOnarim(YerleskeBakimOnarim yerleskeBakimOnarim)
        {
            await _httpClient.PostAsJsonAsync<YerleskeBakimOnarim>("/api/YerleskeBakimOnarims", yerleskeBakimOnarim);
            //response.EnsureSuccessStatusCode();
            return new StatusCodeResult(StatusCodes.Status201Created);
        }

        public Task<IActionResult> PutYerleskeBakimOnarim(int id, YerleskeBakimOnarim yerleskeBakimOnarim)
        {
            throw new NotImplementedException();
        }
    }
}
