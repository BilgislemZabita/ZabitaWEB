using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class TalepSonucu:IEntity
    {

        [Key]
        public virtual int TalepSonucuId { get; set; }

        public virtual int TalepSonucuTipi { get; set; }

        public virtual string TalepSonucuAciklama { get; set; }
        public virtual string TalepSonucuKapanisBilgisi { get; set; }
        public virtual string TalepId { get; set; }
        public virtual ICollection<IsAltTipleri> IsAltTiplerisList { get; set; }

    }
}
