using Zabita.DataAccessLayer.Abstract;
using Zabita.DataAccessLayer.Concrete.EntityFramework;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Concrete
{
    public class EfFotoDal : EfEntityRepositoryBase<Foto, ZabitaDatabaseContext>, IFotoDal
    {

    }
}
