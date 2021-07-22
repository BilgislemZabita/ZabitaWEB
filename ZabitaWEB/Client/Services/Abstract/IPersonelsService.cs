using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface IPersonelsService
    {
        Task<IActionResult> DeletePersonel(int id);

        Task<ActionResult<Personel>> GetPersonel(int id);

        Task<List<Personel>> GetPersonels();
        Task<List<Personel>> GetTalepPersonel(int amirlik, string atama);
        Task<ActionResult<Personel>> PostPersonel(Personel personel);

        Task<IActionResult> PutPersonel(int id, Personel personel);
    }
}