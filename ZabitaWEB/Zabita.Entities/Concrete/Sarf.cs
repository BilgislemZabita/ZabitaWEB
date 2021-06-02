using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class Sarf : IEntity
    {
        [Key]
        public virtual int SarfId { get; set; }
        public virtual string SarfIsım { get; set; }

        public virtual Yerleske SarfYerleske { get; set; }

        public virtual Mudurluk SarfMudurluk { get; set; }

        public virtual Amirlik SarfAmirlik { get; set; }

        public virtual Oda SarfOda { get; set; }

        public virtual Personel SarfPersonel { get; set; }
        public virtual ICollection<Foto> Fotolar { get; set; }

    }
}
