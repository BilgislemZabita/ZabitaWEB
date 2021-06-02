using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface IOdasService
    {
        Task<IActionResult> DeleteOda(int id);

        Task<ActionResult<Oda>> GetOda(int id);

        Task<ActionResult<IEnumerable<Oda>>> GetOdas();

        Task<ActionResult<Oda>> PostOda(Oda oda);

        Task<IActionResult> PutOda(int id, Oda oda);
    }
}