using Zabita.DataAccessLayer.Abstract;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Concrete.EntityFramework
{
    public class EfOdaYerleske : EfEntityRepositoryBase<OdaYerleskec, ZabitaDatabaseContext>, IOdaYerleske
    {
    }
}
