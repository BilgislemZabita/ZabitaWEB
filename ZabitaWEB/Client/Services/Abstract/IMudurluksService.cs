using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface IMudurluksService
    {
        Task<IActionResult> DeleteMudurluk(int id);

        Task<ActionResult<Mudurluk>> GetMudurluk(int id);

        Task<ActionResult<IEnumerable<Mudurluk>>> GetMudurluks();

        Task<ActionResult<Mudurluk>> PostMudurluk(Mudurluk mudurluk);

        Task<IActionResult> PutMudurluk(int id, Mudurluk mudurluk);
    }
}