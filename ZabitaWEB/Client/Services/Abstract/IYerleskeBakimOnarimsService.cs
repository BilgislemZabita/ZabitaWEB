using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface IYerleskeBakimOnarimsService
    {
        Task<IActionResult> DeleteYerleskeBakimOnarim(int id);
        Task<ActionResult<YerleskeBakimOnarim>> GetYerleskeBakimOnarim(int id);
        Task<ActionResult<IEnumerable<YerleskeBakimOnarim>>> GetYerleskeBakimOnarims();
        Task<StatusCodeResult> PostYerleskeBakimOnarim(YerleskeBakimOnarim yerleskeBakimOnarim);
        Task<IActionResult> PutYerleskeBakimOnarim(int id, YerleskeBakimOnarim yerleskeBakimOnarim);
    }
}