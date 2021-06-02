using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class Mudurluk : IEntity
    {

        [Key]
        public virtual int MudurlukId { get; set; }

        public virtual string MudurlukIsim { get; set; }

        public virtual string MudurlukSeriNo { get; set; }
        public virtual ICollection<Yerleske> Yerleskes { get; set; }

        public virtual ICollection<MudurlukYerleskec> MudurlukYerleskecs { get; set; }




        public virtual ICollection<Amirlik> Amirlikler { get; set; }
        public virtual ICollection<Oda> Odalar { get; set; }
        public virtual ICollection<Foto> Fotolar { get; set; }
        public virtual ICollection<Demirbas> Demirbaslar { get; set; }
        public virtual ICollection<Personel> Personeller { get; set; }
        public virtual ICollection<YerleskeBakimOnarim> YerleskeBakimOnarim { get; set; }
        public virtual ICollection<YerleskeIklimlendirme> YerleskeIklimlendirme { get; set; }
        public virtual ICollection<YerleskeTeknikBilgiler> YerleskeTeknikBilgiler { get; set; }
        public virtual ICollection<Sarf> Sarf { get; set; }


    }

    public class MudurlukYerleskec : IEntity
    {
        [Key]

        public virtual int MudurlukId { get; set; }

        public virtual Mudurluk Mudurluk { get; set; }
        [Key]

        public virtual int YerleskeId { get; set; }

        public virtual Yerleske Yerleske { get; set; }

    }
}
