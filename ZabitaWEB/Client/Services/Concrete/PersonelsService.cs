using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Web.Http.Description;
using Zabita.Entities.Concrete;
using ZabitaWEB.Client.Services.Abstract;
using Microsoft.AspNetCore.Http;


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
        // GET: api/Personels/talep/amirlik/3

        public async Task<List<Personel>> GetTalepPersonel(int amirlik,string atama)
        {
            return await _httpClient.GetFromJsonAsync<List<Personel>>("/api/Personels/talep/"+amirlik+"/"+atama);
        }

        public Task<ActionResult<Personel>> PostPersonel(Personel personel)
        {
            throw new NotImplementedException();
        }
        [ResponseType(typeof(Talep))]

        public async Task<ActionResult<StatusCodeResult>> PutPersonel(int id, Personel personel)
        {

            return new StatusCodeResult(StatusCodes.Status200OK);

        }
    }
} 