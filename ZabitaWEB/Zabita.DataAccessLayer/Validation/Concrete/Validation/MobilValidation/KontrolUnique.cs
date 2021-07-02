using Microsoft.EntityFrameworkCore;
using System.Linq;
using Zabita.DataAccessLayer.Concrete.EntityFramework;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Validation.Conrete.Validation.MobilValidation
{
    public class KontrolUnique
    {
        //public bool KontrolPersonelKullaniciAdi(string str)
        //{
        //    using (ZabitaDatabaseContext cont = new ZabitaDatabaseContext())
        //    {
        //        var resultf = (from oda in cont.Set<Personel>().Select(s => s.KullaniciAdi)
        //                       where oda == str
        //                       select oda).Count();

        //        bool result = resultf == 0;

        //        return result;
        //    }
        //}

        //public bool KontrolYerleskeIsim(string str)
        //{
        //    using (ZabitaDatabaseContext cont = (ZabitaDatabaseContext)InstanceFactory.GetInstance<DbContext>())
        //    {
        //        var resultoda = (from oda in cont.Set<Oda>().Select(s => s.OdaIsim)
        //                         where oda == str
        //                         select oda).Count();
        //        var resultamirlik = (from amirlik in cont.Set<Amirlik>().Select(s => s.AmirlikIsım)
        //                             where amirlik == str
        //                             select amirlik).Count();
        //        var resultmudurluk = (from mudurluk in cont.Set<Mudurluk>().Select(s => s.MudurlukIsim)
        //                              where mudurluk == str
        //                              select mudurluk).Count();
        //        var resultyerleske = (from yerleske in cont.Set<Yerleske>().Select(s => s.YerleskeIsim)
        //                              where yerleske == str
        //                              select yerleske).Count();

        //        bool result = resultoda == 0 & resultamirlik == 0 & resultmudurluk == 0 & resultyerleske == 0;

        //        return result;
        //    }
        //}

        //public bool KontrolPersonel(string str)
        //{
        //    using (ZabitaDatabaseContext cont = (ZabitaDatabaseContext)InstanceFactory.GetInstance<DbContext>())
        //    {
        //        var resultpersonel = (from personel in cont.Set<Personel>().Select(s => s.KullaniciAdi)
        //                              where personel == str
        //                              select personel).Count();

        //        bool result = resultpersonel == 0;

        //        return result;
        //    }
        //}
    }
}