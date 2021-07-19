using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class Personel :  IEntity
    {
        [Key]
        public virtual int PersonelId { get; set; }
        //[Key]
        //public virtual int PersonelId { get; set; }
        /* [Key]
         public virtual int Id { get; set; }*/

          public virtual string KullaniciAdi { get; set; }

        public virtual string PersonelIsim { get; set; }

        public virtual string PersonelSoyisim { get; set; }

        public virtual string PersonelSicil { get; set; }

        public virtual string PersonelTelefon { get; set; }

        public virtual string PersonelDahili { get; set; }

        public virtual string YetkiLevel { get; set; }

         public virtual Yetki PersonelYetki { get; set; }
         public virtual string IsAtanabilir { get; set; }

        public virtual Yerleske PersonelYerleske { get; set; }
        public virtual Mudurluk PersonelMudurluk { get; set; }
        public virtual Amirlik PersonelAmirlik { get; set; }
        public virtual Oda PersonelOda { get; set; }
        public virtual ICollection<Foto> Fotolar { get; set; }

        public virtual ICollection<Demirbas> Demirbaslar { get; set; }
        public virtual ICollection<Sarf> Sarf { get; set; }
        public virtual ICollection<Talep> Taleps { get; set; }
        public virtual ICollection<Modul> Moduls { get; set; }
        public virtual ICollection<Yetki> Yetkis { get; set; }
        public virtual ICollection<ModulPersonelc> ModulPersonelcs { get; set; }
   

    }
}