using System.ComponentModel.DataAnnotations;
using Zabita.Entities.Abstract;

namespace Zabita.Entities.Concrete
{
    public class SeriNo : IEntity
    {
        [Key]
        public int SeriNoId { get; set; }
        public string SeriNoAdresleme { get; set; }
        public string SeriNoYerleskeIsim { get; set; }







    }

}
