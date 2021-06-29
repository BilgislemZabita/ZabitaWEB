using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;
using System;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface IDemirbasService
    {
        Task<ActionResult<bool>> DeleteDemirbas(int id);

        Task<ActionResult<Demirbas>> GetDemirbas(int id);

        Task<List<Demirbas>> GetDemirbases();

        Task<Uri> PostDemirbas(Demirbas demirbas);

        Task<IActionResult> PutDemirbas(int id, Demirbas demirbas);
    }
}