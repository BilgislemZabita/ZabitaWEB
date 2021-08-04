using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class YerleskeTeknikBilgiler : IEntity
    {
        [Key]
        public virtual int YerleskeTeknikBilgilerId { get; set; }

        public virtual DateTime KayıtTarihi { get; set; }

        public virtual string InsaatTipi { get; set; }

        public virtual string AlanBilgisi { get; set; }

        public virtual int Uzunluk { get; set; }

        public virtual int Genislik { get; set; }

        public virtual string ZeminBilgisi { get; set; }

        public virtual string KatBilgisi { get; set; }

        public virtual string Aydinlatma { get; set; }

        public virtual string CatiTipi { get; set; }
        public virtual string TeknikBilgilerAciklama { get; set; }

        public virtual bool EngelliErisimi { get; set; }

        public virtual bool Asansör { get; set; }

        public virtual bool AcilCikis { get; set; }

        public virtual bool MerkeziYanginSondurme { get; set; }

        public virtual string Diger { get; set; }
        public virtual Yerleske YerleskeTeknikBilgilerYerleske { get; set; }

        public virtual Mudurluk YerleskeTeknikBilgilerMudurluk { get; set; }

        public virtual Amirlik YerleskeTeknikBilgilerAmirlik { get; set; }

        public virtual Oda YerleskeTeknikBilgilerOda { get; set; }
        public virtual int YerleskeTeknikBilgiTalepId { get; set; }
        public virtual Talep YerleskeTeknikBilgiTalep { get; set; }
        public virtual ICollection<Foto> Fotolar { get; set; }
    }
}