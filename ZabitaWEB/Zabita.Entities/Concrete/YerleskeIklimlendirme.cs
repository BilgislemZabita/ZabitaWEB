using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class YerleskeIklimlendirme : IEntity
    {
        [Key]
        public virtual int YerleskeIklimlendirmeId { get; set; }

        public virtual DateTime KayıtTarihi { get; set; }

        public virtual string IsitmaSistemi { get; set; }

        public virtual string SogutmaSistemi { get; set; }
        public virtual string IklimlendirmeAciklama { get; set; }

        public virtual Yerleske YerleskeIklimlendirmeYerleske { get; set; }

        public virtual Mudurluk YerleskeIklimlendirmeMudurluk { get; set; }

        public virtual Amirlik YerleskeIklimlendirmeAmirlik { get; set; }

        public virtual Oda YerleskeIklimlendirmeOda { get; set; }
        public virtual ICollection<Foto> Fotolar { get; set; }
    }
}