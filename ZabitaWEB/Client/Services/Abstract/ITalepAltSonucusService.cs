using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface ITalepAltSonucusService
    {
        Task<IActionResult> DeleteTalepAltSonucu(int id);
        Task<ActionResult<TalepAltSonucu>> GetTalepAltSonucu(int id);
        Task<ActionResult<IEnumerable<TalepAltSonucu>>> GetTalepAltSonucus();
        Task<StatusCodeResult> PostTalepAltSonucu(TalepAltSonucu talepAltSonucu);
        Task<IActionResult> PutTalepAltSonucu(int id, TalepAltSonucu talepAltSonucu);
    }
}