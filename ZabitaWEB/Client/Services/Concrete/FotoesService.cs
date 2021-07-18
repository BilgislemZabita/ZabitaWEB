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
    public class FotoesService : IFotoesService
    {
        private readonly HttpClient _httpClient;

        public FotoesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Foto>> GetTalepFoto(int id)
        {
            return await _httpClient.GetFromJsonAsync<List<Foto>>("/api/Fotoes/talep/" + id.ToString());
        }

        Task<ActionResult<bool>> IFotoesService.DeleteFoto(int id)
        {
            throw new NotImplementedException();
        }

        Task<ActionResult<Foto>> IFotoesService.GetFoto(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Foto>> IFotoesService.GetFotolars()
        {
            throw new NotImplementedException();
        }

        Task<Uri> IFotoesService.PostFoto(Foto foto)
        {
            throw new NotImplementedException();
        }

        Task<IActionResult> IFotoesService.PutFoto(int id, Foto foto)
        {
            throw new NotImplementedException();
        }
    }
}