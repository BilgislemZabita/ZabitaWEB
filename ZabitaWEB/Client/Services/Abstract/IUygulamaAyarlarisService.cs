using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface IUygulamaAyarlarisService
    {
        Task<IActionResult> DeleteUygulamaAyarlari(int id);
        Task<ActionResult<UygulamaAyarlari>> GetUygulamaAyarlari(int id);
        Task<List<UygulamaAyarlari>> GetUygulamaAyarlaris();
        Task<ActionResult<UygulamaAyarlari>> PostUygulamaAyarlari(UygulamaAyarlari uygulamaAyarlari);
        Task<IActionResult> PutUygulamaAyarlari(int id, UygulamaAyarlari uygulamaAyarlari);
    }
}