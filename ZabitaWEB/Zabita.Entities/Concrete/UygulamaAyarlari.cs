using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class UygulamaAyarlari : IEntity
    {
        [Key]
        public virtual int UygulamaAyarId { get; set; }

        public virtual string UygulamaYetkiTipleri { get; set; }
    }
}