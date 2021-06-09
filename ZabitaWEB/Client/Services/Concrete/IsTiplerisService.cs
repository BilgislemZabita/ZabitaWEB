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
    public class IsTiplerisService : IIsTiplerisService
    {
        private readonly HttpClient _httpClient;

        public IsTiplerisService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task<IActionResult> DeleteIsTipleri(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Taleptipleri>> GetIsTipleri(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Taleptipleri>> GetIsTipleris()
        {
            return await _httpClient.GetFromJsonAsync<List<Taleptipleri>>("/api/IsTipleris");
        }

        public Task<ActionResult<Taleptipleri>> PostIsTipleri(Taleptipleri isTipleri)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutIsTipleri(int id, Taleptipleri isTipleri)
        {
            throw new NotImplementedException();
        }
    }
}
