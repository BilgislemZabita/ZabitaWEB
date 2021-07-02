using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class IsTipleri:IEntity
    {

        [Key]
        public virtual int IstipiID { get; set; }
        public virtual string IsTipi { get; set; }
        public virtual string AmirlikId { get; set; }
        public virtual string AmirlikIsim { get; set; }

    }
}
