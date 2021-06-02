using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Validation.Abstract.Validation.MobilValidation
{
    public interface IModulValidator
    {
        ValidationResult Validate(Modul modul);
    }
}
