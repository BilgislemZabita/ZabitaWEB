using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class Yerleske : IEntity
    {
        [Key]
        public virtual int YerleskeId { get; set; }

        public virtual string YerleskeIsim { get; set; }

        public virtual string YerleskeSeriNo { get; set; }
        public virtual ICollection<Oda> Odas { get; set; }
        public virtual ICollection<Amirlik> Amirliks { get; set; }
        public virtual ICollection<Mudurluk> Mudurluks { get; set; }

        public virtual ICollection<MudurlukYerleskec> MudurlukYerleskecs { get; set; }

        public virtual ICollection<AmirlikYerleskec> AmirlikYerleskecs { get; set; }
        public virtual ICollection<OdaYerleskec> OdaYerleskecs { get; set; }
        public virtual ICollection<Demirbas> Demirbaslar { get; set; }
        public virtual ICollection<Foto> Fotolar { get; set; }

        public virtual ICollection<Personel> Personeller { get; set; }
        public virtual ICollection<YerleskeBakimOnarim> YerleskeBakimOnarim { get; set; }
        public virtual ICollection<YerleskeIklimlendirme> YerleskeIklimlendirme { get; set; }
        public virtual ICollection<YerleskeTeknikBilgiler> YerleskeTeknikBilgiler { get; set; }
        public virtual ICollection<Sarf> Sarf { get; set; }
    }
}