using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class Demirbas : IEntity
    {
        [Key]
        public virtual int DemirbasId { get; set; }


        public virtual string DemirbasIsim { get; set; }

        public virtual Yerleske DemirbasYerleske { get; set; }

        public virtual Mudurluk DemirbasMudurluk { get; set; }

        public virtual Amirlik DemirbasAmirlik { get; set; }

        public virtual Oda DemirbasOda { get; set; }

        public virtual Personel DemirbasPersonel { get; set; }

        public virtual ICollection<Foto> Fotolar { get; set; }




    }
}
