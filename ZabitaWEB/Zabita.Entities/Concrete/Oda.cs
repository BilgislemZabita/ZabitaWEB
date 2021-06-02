using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class Oda : IEntity
    {
        [Key]
        public virtual int OdaId { get; set; }

        public virtual string OdaIsim { get; set; }

        public virtual string OdaSeriNo { get; set; }


        public virtual Mudurluk OdaMudurluk { get; set; }

        public virtual Amirlik OdaAmirlik { get; set; }
        public virtual ICollection<Yerleske> Yerleskes { get; set; }

        public virtual List<OdaYerleskec> OdaYerleskecs { get; set; }

        public virtual ICollection<Demirbas> Demirbaslar { get; set; }
        public virtual ICollection<Foto> Fotolar { get; set; }

        public virtual ICollection<Personel> Personeller { get; set; }
        public virtual ICollection<YerleskeBakimOnarim> YerleskeBakimOnarim { get; set; }
        public virtual ICollection<YerleskeIklimlendirme> YerleskeIklimlendirme { get; set; }
        public virtual ICollection<YerleskeTeknikBilgiler> YerleskeTeknikBilgiler { get; set; }
        public virtual ICollection<Sarf> Sarf { get; set; }
    }

    public class OdaYerleskec : IEntity
    {
        [Key]

        public virtual int OdaId { get; set; }

        public virtual Oda Oda { get; set; }
        [Key]

        public virtual int YerleskeId { get; set; }

        public virtual Yerleske Yerleske { get; set; }
    }
}
