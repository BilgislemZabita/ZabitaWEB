using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;
using System;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface IFotoesService
    {
        Task<ActionResult<bool>> DeleteFoto(int id);

        Task<ActionResult<Foto>> GetFoto(int id);
        Task<List<Foto>> GetTalepFoto(int id);

        Task<List<Foto>>  GetFotolars();

        Task<Uri> PostFoto(Foto foto);

        Task<IActionResult> PutFoto(int id, Foto foto);
    }
}