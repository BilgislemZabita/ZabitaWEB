using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface IIsAltTiplerisService
    {
        Task<IActionResult> DeleteIsAltTipleri(int id);
        Task<ActionResult<IsAltTipleri>> GetIsAltTipleri(int id);
        Task<List<IsAltTipleri>> GetIsAltTipleris();
        Task<ActionResult<IsAltTipleri>> PostIsAltTipleri(IsAltTipleri isAltTipleri);
        Task<IActionResult> PutIsAltTipleri(int id, IsAltTipleri isAltTipleri);
    }
}