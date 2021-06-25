using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class IsAltTipleri: IEntity
    {
        [Key]
        public virtual int IsAltTipiId { get; set; }
        public virtual string IsAltTipi { get; set; }
        //public virtual Amirlik IsTipiAmirlik { get; set; }
        public virtual string IstipiId { get; set; }
        public virtual string IsAltTipiAciklama { get; set; }

    }
}
