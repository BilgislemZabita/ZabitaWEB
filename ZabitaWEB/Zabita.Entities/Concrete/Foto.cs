using System;
using System.ComponentModel.DataAnnotations;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class Foto : IEntity
    {
        [Key]
        public virtual int FotoId { get; set; }
        public virtual string FotoAdi { get; set; }
        public virtual string FotoAciklama { get; set; }
        public virtual byte[] FotoData { get; set; }
        public virtual DateTime FotoEklenmeTarihi { get; set; }
        public virtual string YapilanIsAdi { get; set; }

        public virtual string YapilanIs { get; set; }

        public virtual Mudurluk FotoMudurluk { get; set; }

        public virtual Amirlik FotoAmirlik { get; set; }
        public virtual Oda FotoOda { get; set; }
        public virtual Personel FotoPersonel { get; set; }
        public virtual Yerleske FotoYerleske { get; set; }
        public virtual Demirbas FotoDemirbas { get; set; }
        public virtual Sarf FotoSarf { get; set; }
        public virtual YerleskeIklimlendirme FotoYerleskeIklimlendirme { get; set; }
        public virtual YerleskeBakimOnarim FotoYerleskeBakimOnarim { get; set; }
        public virtual YerleskeTeknikBilgiler FotoYerleskeTeknikBilgiler { get; set; }
    }
}
