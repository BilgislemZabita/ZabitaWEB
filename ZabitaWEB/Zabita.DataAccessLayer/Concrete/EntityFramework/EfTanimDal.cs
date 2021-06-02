using Zabita.DataAccessLayer.Abstract;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Concrete.EntityFramework
{
    public class EfTanimDal : EfEntityRepositoryBase<Tanimlamalar, ZabitaDatabaseContext>, ITanimDal
    {

    }
}
