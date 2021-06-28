using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;
using ZabitaWEB.Client.Services.Abstract;

namespace ZabitaWEB.Client.Services.Concrete
{
    public class IsAltTipleriService : IIsAltTiplerisService
    {
        private readonly HttpClient _httpClient;

        public IsAltTipleriService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<IActionResult> DeleteIsAltTipleri(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IsAltTipleri>> GetIsAltTipleri(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<IsAltTipleri>> GetIsAltTipleris()
        {
            return await _httpClient.GetFromJsonAsync<List<IsAltTipleri>>("/api/IsAltTipleris");
        }

        public Task<ActionResult<IsAltTipleri>> PostIsAltTipleri(IsAltTipleri isAltTipleri)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutIsAltTipleri(int id, IsAltTipleri isAltTipleri)
        {
            throw new NotImplementedException();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
