using FluentValidation;
using Zabita.DataAccessLayer.Validation.Abstract.Validation.MobilValidation;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Validation.Conrete.Validation.MobilValidation
{
    public class OdaValidator : AbstractValidator<Oda>, IOdaValidator
    {
        public OdaValidator()
        {
            RuleFor(x => x.OdaIsim).NotEmpty().WithMessage("Oda ismini boş bırakma");
            RuleFor(x => x.OdaSeriNo).NotEmpty().WithMessage("Oda seri no boş bırakma");
            // RuleFor(x => x.OdaSeriNo).Must(IsUnique).WithMessage("Sistem No benzersiz olmalı!!!").WithSeverity(Severity.Warning);
            // RuleFor(x => x.OdaIsim).Must(IsUniqueIsim).WithMessage("Oda ismi benzersiz olmalı!!!").WithSeverity(Severity.Warning);
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