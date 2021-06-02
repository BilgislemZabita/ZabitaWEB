using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface IDemirbasService
    {
        Task<IActionResult> DeleteDemirbas(int id);

        Task<ActionResult<Demirbas>> GetDemirbas(int id);

        Task<ActionResult<IEnumerable<Demirbas>>> GetDemirbases();

        Task<ActionResult<Demirbas>> PostDemirbas(Demirbas demirbas);

        Task<IActionResult> PutDemirbas(int id, Demirbas demirbas);
    }
}