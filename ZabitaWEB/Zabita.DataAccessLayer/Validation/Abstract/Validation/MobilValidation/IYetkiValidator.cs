using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Validation.Abstract.Validation.MobilValidation
{
    public interface IYetkiValidator
    {
        ValidationResult Validate(Yetki yetki);
    }
}
