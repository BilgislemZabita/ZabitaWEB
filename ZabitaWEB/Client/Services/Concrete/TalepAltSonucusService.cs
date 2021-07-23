using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;
using ZabitaWEB.Client.Services.Abstract;

namespace ZabitaWEB.Client.Services.Concrete
{
    public class TalepAltSonucusService : ITalepAltSonucusService
    {
        Task<IActionResult> ITalepAltSonucusService.DeleteTalepAltSonucu(int id)
        {
            throw new NotImplementedException();
        }

        Task<ActionResult<TalepAltSonucu>> ITalepAltSonucusService.GetTalepAltSonucu(int id)
        {
            throw new NotImplementedException();
        }

        Task<ActionResult<IEnumerable<TalepAltSonucu>>> ITalepAltSonucusService.GetTalepAltSonucus()
        {
            throw new NotImplementedException();
        }

        Task<ActionResult<TalepAltSonucu>> ITalepAltSonucusService.PostTalepAltSonucu(TalepAltSonucu talepAltSonucu)
        {
            throw new NotImplementedException();
        }

        Task<IActionResult> ITalepAltSonucusService.PutTalepAltSonucu(int id, TalepAltSonucu talepAltSonucu)
        {
            throw new NotImplementedException();
        }
    }
}
