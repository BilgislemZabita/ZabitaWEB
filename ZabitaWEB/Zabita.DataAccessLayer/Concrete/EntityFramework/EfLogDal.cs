using System;
using System.Collections.Generic;
using System.Text;
using Zabita.DataAccessLayer.Abstract;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Concrete.EntityFramework
{
    public class EfLogDal : EfEntityRepositoryBase<Log, ZabitaDatabaseContext>, ILogDal
    {
    }
}