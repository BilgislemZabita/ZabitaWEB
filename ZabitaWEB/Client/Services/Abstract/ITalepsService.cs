using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface ITalepsService
    {
        Task<IActionResult> DeleteTalep(int id);
        Task<ActionResult<Talep>> GetTalep(int id);
        Task<ActionResult<IEnumerable<Talep>>> GetTaleps();
        Task<ActionResult<Talep>> PostTalep(Talep talep);
        Task<IActionResult> PutTalep(int id, Talep talep);
    }
}