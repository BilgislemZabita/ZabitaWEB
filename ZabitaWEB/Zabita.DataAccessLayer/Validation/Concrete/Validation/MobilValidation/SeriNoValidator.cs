using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Zabita.DataAccessLayer.Concrete.EntityFramework;
using Zabita.DataAccessLayer.Validation.Abstract.Validation.MobilValidation;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Validation.Conrete.Validation.MobilValidation
{
    public class SeriNoValidator : AbstractValidator<SeriNo>, ISeriNoValidator
    {
        //public SeriNoValidator()
        //{
        //    RuleFor(x => x.SeriNoAdresleme).Must(IsNameUnique).WithMessage("Sistem No benzersiz olmalı!!");

        //}
        //public bool IsNameUnique(string str)
        //{
        //    using (ZabitaDatabaseContext cont = (ZabitaDatabaseContext)InstanceFactory.GetInstance<DbContext>())
        //    {
        //        var result = (from serino in cont.Set<SeriNo>().Select(s => s.SeriNoAdresleme)
        //                      where serino == str
        //                      select serino);

        //        if (result.Count() == 0)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;

        //        }
        //    }
        //}
    }
}