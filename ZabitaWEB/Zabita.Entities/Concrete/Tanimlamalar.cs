using System.ComponentModel.DataAnnotations;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class Tanimlamalar : IEntity
    {

        [Key]
        public virtual int TanimlamalarId { get; set; }

        public virtual string Insaattipi { get; set; }
        public virtual string Aydinlatma { get; set; }
        public virtual string Catitipi { get; set; }
        public virtual string Zeminbilgisi { get; set; }
        public virtual string Isitmatipi { get; set; }
        public virtual string Sogutmatipi { get; set; }



    }
}
