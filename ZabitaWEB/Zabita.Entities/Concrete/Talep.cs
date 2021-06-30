using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class Talep : IEntity
    {
        [Key]
        public virtual int TalepId { get; set; }

        public virtual int TalepTipi { get; set; }

        public virtual string TalepBaslik { get; set; }
        public virtual string TalepKonu { get; set; }
        public virtual string TalepAciklama { get; set; }
        public virtual string YerleskeAciklamasi { get; set; }
        public virtual Amirlik TalepAmirlik { get; set; }
        public virtual IsTipleri IsTiplerid { get; set; }
        public virtual Personel TalebiIsteyenPersonel { get; set; }
        public virtual Personel TalebiKarsilayanPersonel { get; set; }
        public virtual DateTime TalebinYapilmaTarihi { get; set; }
        public virtual DateTime TalebinKarsilanmaTarihi { get; set; }
        public virtual ICollection<Foto> Fotolar { get; set; }
        public virtual ICollection<IsAltTipleri> IsAltTipleris { get; set; }
    }
}