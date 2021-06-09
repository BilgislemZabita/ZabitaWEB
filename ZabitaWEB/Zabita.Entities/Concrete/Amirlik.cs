using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class Amirlik : IEntity
    {
        [Key]
        public virtual int AmirlikID { get; set; }

        public virtual string AmirlikIsım { get; set; }

        public virtual string AmirlikSeriNo { get; set; }

        public virtual Mudurluk AmirlikMudurluk { get; set; }

        public virtual ICollection<Yerleske> Yerleskes { get; set; }

        public virtual List<AmirlikYerleskec> AmirlikYerleskecs { get; set; }

        public virtual ICollection<Oda> Odalar { get; set; }
        public virtual ICollection<Taleptipleri> IsTipleri { get; set; }
        public virtual ICollection<Demirbas> Demirbaslar { get; set; }
        public virtual ICollection<Foto> Fotolar { get; set; }

        public virtual ICollection<Personel> Personeller { get; set; }
        public virtual ICollection<YerleskeBakimOnarim> YerleskeBakimOnarim { get; set; }
        public virtual ICollection<YerleskeIklimlendirme> YerleskeIklimlendirme { get; set; }
        public virtual ICollection<YerleskeTeknikBilgiler> YerleskeTeknikBilgiler { get; set; }
        public virtual ICollection<Sarf> Sarf { get; set; }
    }

    public class AmirlikYerleskec : IEntity
    {
        [Key]
        public virtual int AmirlikID { get; set; }

        public virtual Amirlik Amirlik { get; set; }

        [Key]
        public virtual int YerleskeId { get; set; }

        public virtual Yerleske Yerleske { get; set; }
    }
}