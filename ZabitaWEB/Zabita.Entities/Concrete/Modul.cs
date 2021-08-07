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
       // public virtual ICollection<Yetki> YetkiModuller { get; set; }
        public virtual ICollection<Personel> Personels { get; set; }
    }

  
}