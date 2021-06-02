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
    public class YerleskesService : IYerleskesService
    {
        private readonly HttpClient httpClient;

        public YerleskesService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<IActionResult> DeleteYerleske(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Yerleske>> GetYerleske(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Yerleske>> GetYerleskes()
        {
            return await httpClient.GetFromJsonAsync<List<Yerleske>>("/api/Yerleskes");
        }

        public Task<ActionResult<Yerleske>> PostYerleske(Yerleske yerleske)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutYerleske(int id, Yerleske yerleske)
        {
            throw new NotImplementedException();
        }
    }
}