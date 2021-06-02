using Zabita.DataAccessLayer.Abstract;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Concrete.EntityFramework
{
    public class EfIklimlendirmeDal : EfEntityRepositoryBase<YerleskeIklimlendirme, ZabitaDatabaseContext>, IIklimlendirmeDal
    {
    }
}
