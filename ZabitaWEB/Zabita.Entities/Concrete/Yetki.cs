using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class Yetki:IdentityRole, IEntity
    {
        [Key]
        public virtual int YetkiId { get; set; }

        public virtual bool Okuma { get; set; }
        public virtual bool Yazma { get; set; }
        public virtual bool Silme { get; set; }
        public virtual bool Guncelleme { get; set; }
        public virtual bool Yetkilendirme { get; set; }
        public virtual bool PersonelYetkisi { get; set; }
        public virtual bool ModulYoneticisiYetkisi { get; set; }
        public virtual bool AdminYetkisi { get; set; }
        public virtual bool YoneticiYetkisi { get; set; }

        //public virtual ICollection<Modul> YetkiModuller { get; set; }
        public virtual int YetkiTipi { get; set; }

        public virtual Personel Personel { get; set; }
        public virtual Modul Modul { get; set; }
    }
}