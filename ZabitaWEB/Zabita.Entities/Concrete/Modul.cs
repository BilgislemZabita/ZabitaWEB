using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class Modul : IEntity
    {
        [Key]
        public virtual int ModulId { get; set; }

        public virtual string ModulIsim { get; set; }
        public virtual ICollection<Yetki> YetkiModuller { get; set; }
        public virtual ICollection<Personel> Personels { get; set; }
        public virtual List<ModulPersonelc> ModulPersonelcs { get; set; }
    }

    public class ModulPersonelc : IEntity
    {
        [Key]
        public virtual int ModulId { get; set; }

        public virtual Modul Modul { get; set; }

        [Key]
        public virtual int PersonelId { get; set; }

        public virtual Personel Personel { get; set; }
    }
}