using FluentValidation;
using Zabita.DataAccessLayer.Validation.Abstract.Validation.MobilValidation;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Validation.Conrete.Validation.MobilValidation
{
    public class AmirlikValidator : AbstractValidator<Amirlik>, IAmirlikValidator
    {
        public AmirlikValidator()
        {
            RuleFor(x => x.AmirlikIsım).NotEmpty().WithMessage("Amirlik ismini boş bırakma");
            RuleFor(x => x.AmirlikSeriNo).NotEmpty().WithMessage("Amirlik seri no boş bırakma");
            //RuleFor(x => x.AmirlikSeriNo).Must(IsUnique).WithMessage("Sistem No benzersiz olmalı!!!").WithSeverity(Severity.Warning);
            //RuleFor(x => x.AmirlikIsım).Must(IsUniqueIsim).WithMessage("Amirlik ismi benzersiz olmalı!!!").WithSeverity(Severity.Warning);
        }

        //private bool IsUnique(string str)
        //{
        //    KontrolUnique kontrolUnique = new KontrolUnique();
        //    var result = kontrolUnique.KontrolYerleskeSeriNo(str);
        //    return result;
        //}

        //private bool IsUniqueIsim(string str)
        //{
        //    KontrolUnique kontrolUnique = new KontrolUnique();
        //    var result = kontrolUnique.KontrolYerleskeIsim(str);
        //    return result;
        //}
    }
}