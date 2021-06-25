using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface IIsTiplerisService
    {
        Task<IActionResult> DeleteIsTipleri(int id);
        Task<ActionResult<IsTipleri>> GetIsTipleri(int id);
        Task<List<IsTipleri>> GetIsTipleris();
        Task<ActionResult<IsTipleri>> PostIsTipleri(IsTipleri isTipleri);
        Task<IActionResult> PutIsTipleri(int id, IsTipleri isTipleri);
    }
}