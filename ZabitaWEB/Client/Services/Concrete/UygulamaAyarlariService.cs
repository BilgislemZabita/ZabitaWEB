using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;
using ZabitaWEB.Client.Services.Abstract;

namespace ZabitaWEB.Client.Services.Concrete
{
    public class UygulamaAyarlariService : IUygulamaAyarlarisService
    {
        public readonly HttpClient _httpClient;

        public UygulamaAyarlariService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<IActionResult> DeleteUygulamaAyarlari(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<UygulamaAyarlari>> GetUygulamaAyarlari(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UygulamaAyarlari>> GetUygulamaAyarlaris()
        {
            return await _httpClient.GetFromJsonAsync<List<UygulamaAyarlari>>("/api/uygulamaAyarlaris");
        }

        public Task<ActionResult<UygulamaAyarlari>> PostUygulamaAyarlari(UygulamaAyarlari uygulamaAyarlari)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutUygulamaAyarlari(int id, UygulamaAyarlari uygulamaAyarlari)
        {
            throw new NotImplementedException();
        }
    }
}