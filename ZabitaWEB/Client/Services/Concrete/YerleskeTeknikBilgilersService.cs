using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;
using ZabitaWEB.Client.Services.Abstract;


namespace ZabitaWEB.Client.Services.Concrete
{
    public class YerleskeTeknikBilgilersService : IYerleskeTeknikBilgilersService
    {
        private readonly HttpClient _httpClient;
        public YerleskeTeknikBilgilersService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }
        public Task<IActionResult> DeleteYerleskeTeknikBilgiler(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<YerleskeTeknikBilgiler>> GetYerleskeTeknikBilgiler(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<YerleskeTeknikBilgiler>>> GetYerleskeTeknikBilgilers()
        {
            throw new NotImplementedException();
        }

        public async Task<StatusCodeResult> PostYerleskeTeknikBilgiler(YerleskeTeknikBilgiler yerleskeTeknikBilgiler)
        {
            await _httpClient.PostAsJsonAsync<YerleskeTeknikBilgiler>("/api/YerleskeTeknikBilgilers", yerleskeTeknikBilgiler);
            //response.EnsureSuccessStatusCode();
            return new StatusCodeResult(StatusCodes.Status201Created);
        }

      
        public Task<IActionResult> PutYerleskeTeknikBilgiler(int id, YerleskeTeknikBilgiler yerleskeTeknikBilgiler)
        {
            throw new NotImplementedException();
        }
    }
}
