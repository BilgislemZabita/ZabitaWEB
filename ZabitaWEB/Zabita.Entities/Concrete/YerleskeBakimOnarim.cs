using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class YerleskeBakimOnarim : IEntity
    {

        [Key]
        public virtual int YerleskeBakimOnarimId { get; set; }

        public virtual DateTime BoyamaTarih { get; set; }

        public virtual DateTime ElektrikBakimTarih { get; set; }

        public virtual DateTime SihhiTesisatBakimTarih { get; set; }
        public virtual string BakımOnarimAciklama { get; set; }

        public virtual Yerleske YerleskeBakimOnarimYerleske { get; set; }

        public virtual Mudurluk YerleskeBakimOnarimMudurluk { get; set; }

        public virtual Amirlik YerleskeBakimOnarimAmirlik { get; set; }

        public virtual Oda YerleskeBakimOnarimOda { get; set; }

        public virtual ICollection<Personel> Personeller { get; set; }
        //public virtual int YerleskeBakimOnarimTalepId { get; set; }
        public virtual Talep YerleskeBakimOnarimTalep { get; set; }
        public virtual ICollection<Foto> Fotolar { get; set; }


    }
}
