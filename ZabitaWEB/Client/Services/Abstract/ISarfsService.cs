using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface ISarfsService
    {
        Task<IActionResult> DeleteSarf(int id);

        Task<ActionResult<Sarf>> GetSarf(int id);

        Task<ActionResult<IEnumerable<Sarf>>> GetSarfs();

        Task<ActionResult<Sarf>> PostSarf(Sarf sarf);

        Task<IActionResult> PutSarf(int id, Sarf sarf);
    }
}