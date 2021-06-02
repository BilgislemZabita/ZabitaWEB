using FluentValidation;
using Zabita.DataAccessLayer.Validation.Abstract.Validation.MobilValidation;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Validation.Conrete.Validation.MobilValidation
{
    public class YerleskeValidator : AbstractValidator<Yerleske>, IYerleskeValidator
    {
        public YerleskeValidator()
        {
            RuleFor(x => x.YerleskeIsim).NotEmpty().WithMessage("Yerleşke ismi boş bırakmayın");
            RuleFor(x => x.YerleskeSeriNo).NotEmpty().WithMessage("Yerleşke seri no boş bırakmayın");
            //RuleFor(x => x.YerleskeSeriNo).Must(IsUnique).WithMessage("Sistem No benzersiz olmalı!!!").WithSeverity(Severity.Warning);
            // RuleFor(x => x.YerleskeIsim).Must(IsUniqueIsim).WithMessage("Yerleşke ismi benzersiz olmalı!!!").WithSeverity(Severity.Warning);
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