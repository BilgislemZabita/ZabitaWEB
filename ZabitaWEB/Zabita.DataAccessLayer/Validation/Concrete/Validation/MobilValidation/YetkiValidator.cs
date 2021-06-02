using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabita.DataAccessLayer.Validation.Abstract.Validation.MobilValidation;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Validation.Concrete.Validation.MobilValidation
{
    public class YetkiValidator : AbstractValidator<Yetki>, IYetkiValidator
    {
        public YetkiValidator()
        {

        }
    }
}
