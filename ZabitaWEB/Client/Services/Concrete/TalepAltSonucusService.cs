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
    public class TalepAltSonucusService : ITalepAltSonucusService
    {
        private readonly HttpClient _httpClient;

        public TalepAltSonucusService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }
        public Task<IActionResult> DeleteTalepAltSonucu(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<TalepAltSonucu>> GetTalepAltSonucu(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<TalepAltSonucu>>> GetTalepAltSonucus()
        {
            throw new NotImplementedException();
        }

        public async Task<StatusCodeResult> PostTalepAltSonucu(TalepAltSonucu talepAltSonucu)
        {
           var tlpaltsnc= await _httpClient.PostAsJsonAsync<TalepAltSonucu>("/api/TalepAltSonucus", talepAltSonucu);
            //response.EnsureSuccessStatusCode();
            return new StatusCodeResult(StatusCodes.Status201Created);
        }

        public Task<IActionResult> PutTalepAltSonucu(int id, TalepAltSonucu talepAltSonucu)
        {
            throw new NotImplementedException();
        }

       
    }
}
