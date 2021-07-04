using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;
using ZabitaWEB.Client.Services.Concrete;
using ZabitaWEB.Client.Services.Abstract;

namespace ZabitaWEB.Client
{
    public static class Preloading
    {
        private static IIsTiplerisService isTiplerisService;
        public static List<IsTipleri> IsTipleris { get; set; }
        public async static void Preloadings()
        {

            var lististipleri = await isTiplerisService.GetIsTipleris();
            IsTipleris = lististipleri;

        }

    }
}
