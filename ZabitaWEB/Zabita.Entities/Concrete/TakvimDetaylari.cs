using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class TakvimDetaylari : IEntity
    {
        [Key]
        public virtual int TakvimDetaylariId { get; set; }
        public virtual DateTime TakvimDetayBilgisi { get; set; }
        public virtual Takvim TakvimTakvimDetaylari { get; set; }

    }
}
