using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Zabita.DataAccessLayer.Validation.Abstract.Validation.MobilValidation;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Validation.Conrete.Validation.MobilValidation
{
    public class PersonelValidator : AbstractValidator<Personel>, IPersonelValidator
    {
        public PersonelValidator()
        {
            RuleFor(x => x.KullaniciAdi).NotEmpty().WithMessage("Kullanıcı adını boş bırakma!");
            RuleFor(x => x.KullaniciAdi).Must(IsUnique).WithMessage("Kullanıcı adı veritabanında mevcut!!!").WithSeverity(Severity.Warning);
        }

        private bool IsUnique(string str)
        {
            KontrolUnique kontrolUnique = new KontrolUnique();
            var result = kontrolUnique.KontrolPersonelKullaniciAdi(str);
            return result;
        }
    }
}