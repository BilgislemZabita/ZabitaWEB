using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface IYerleskesService
    {
        Task<IActionResult> DeleteYerleske(int id);

        Task<ActionResult<Yerleske>> GetYerleske(int id);

        Task<List<Yerleske>> GetYerleskes();

        Task<ActionResult<Yerleske>> PostYerleske(Yerleske yerleske);

        Task<IActionResult> PutYerleske(int id, Yerleske yerleske);
    }
}