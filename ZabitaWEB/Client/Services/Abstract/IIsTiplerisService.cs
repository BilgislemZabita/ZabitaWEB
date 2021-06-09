using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface IIsTiplerisService
    {
        Task<IActionResult> DeleteIsTipleri(int id);
        Task<ActionResult<Taleptipleri>> GetIsTipleri(int id);
        Task<List<Taleptipleri>> GetIsTipleris();
        Task<ActionResult<Taleptipleri>> PostIsTipleri(Taleptipleri isTipleri);
        Task<IActionResult> PutIsTipleri(int id, Taleptipleri isTipleri);
    }
}