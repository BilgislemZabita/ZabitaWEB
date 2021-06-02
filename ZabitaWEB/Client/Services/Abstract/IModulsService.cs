using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface IModulsService
    {
        Task<IActionResult> DeleteModul(int id);

        Task<ActionResult<Modul>> GetModul(int id);

        Task<List<Modul>> GetModuls();

        Task<ActionResult<Modul>> PostModul(Modul modul);

        Task<IActionResult> PutModul(int id, Modul modul);
    }
}