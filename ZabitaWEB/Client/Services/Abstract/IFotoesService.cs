using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface IFotoesService
    {
        Task<IActionResult> DeleteFoto(int id);

        Task<ActionResult<Foto>> GetFoto(int id);

        Task<ActionResult<IEnumerable<Foto>>> GetFotolars();

        Task<ActionResult<Foto>> PostFoto(Foto foto);

        Task<IActionResult> PutFoto(int id, Foto foto);
    }
}