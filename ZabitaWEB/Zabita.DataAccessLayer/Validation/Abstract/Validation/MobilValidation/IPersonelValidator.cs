using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Validation.Abstract.Validation.MobilValidation
{
    public interface IPersonelValidator
    {
        ValidationResult Validate(Personel personel);
    }
}