using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class Takvim : IEntity
    {
        [Key]
        public virtual int TakvimId { get; set; }
        public virtual string TakvimIsım { get; set; }
        public virtual int TakvimTip { get; set; }
        public virtual string TakvimSahibi { get; set; }
        public virtual ICollection<TakvimDetaylari> TakvimDetaylaris { get; set; }

    }
}
