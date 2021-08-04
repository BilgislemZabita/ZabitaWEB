using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface IYerleskeTeknikBilgilersService
    {
        Task<IActionResult> DeleteYerleskeTeknikBilgiler(int id);
        Task<ActionResult<YerleskeTeknikBilgiler>> GetYerleskeTeknikBilgiler(int id);
        Task<ActionResult<IEnumerable<YerleskeTeknikBilgiler>>> GetYerleskeTeknikBilgilers();
        Task<StatusCodeResult> PostYerleskeTeknikBilgiler(YerleskeTeknikBilgiler yerleskeTeknikBilgiler);
        Task<IActionResult> PutYerleskeTeknikBilgiler(int id, YerleskeTeknikBilgiler yerleskeTeknikBilgiler);
    }
}