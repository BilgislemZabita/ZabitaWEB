using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface IYetkisService
    {
        Task<IActionResult> DeleteYetki(int id);

        Task<ActionResult<Yetki>> GetYetki(int id);

        Task<List<Yetki>> GetYetkis();

        Task<Uri> PostYetki(Yetki yetki);

        Task<IActionResult> PutYetki(int id, Yetki yetki);
    }
}