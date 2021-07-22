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
        //public virtual string DenemeHJG { get; set; }
        public virtual string TalepAciklama { get; set; }
        public virtual string YerleskeAciklamasi { get; set; }
        public virtual string AmirlikId { get; set; }
        public virtual Amirlik TalepAmirlik { get; set; }
        public virtual IsTipleri TalepIstipleri { get; set; }
        public virtual string TalepIstipleriID { get; set; }
       // public int PersonelId { get; set; }
        public virtual Personel Personel { get; set; }
        public virtual int TalebiAtayanPersonelId { get; set; }
        public virtual int TalebiIsteyenPersonelId { get; set; }
        public virtual int TalebiKarsilayanPersonelId { get; set; }
        public virtual DateTime TalebinYapilmaTarihi { get; set; }
        public virtual DateTime TalebinKarsilanmaTarihi { get; set; }
        public virtual DateTime TalebinAtanmaTarihi { get; set; }
        public virtual ICollection<Foto> Fotolar { get; set; }
        public virtual ICollection<TalepAltSonucu> TalepAltSonucus { get; set; }
        public virtual string TalepKapanisBilgisi { get; set; }
    }
}