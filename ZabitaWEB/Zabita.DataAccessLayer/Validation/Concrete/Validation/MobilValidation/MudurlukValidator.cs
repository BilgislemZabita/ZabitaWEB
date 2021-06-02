using FluentValidation;
using Zabita.DataAccessLayer.Validation.Abstract.Validation.MobilValidation;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Validation.Conrete.Validation.MobilValidation
{
    public class MudurlukValidator : AbstractValidator<Mudurluk>, IMudurlukValidator
    {
        public MudurlukValidator()
        {
            RuleFor(s => s.MudurlukIsim).NotEmpty().WithMessage("Müdürlük İsmi Boş Bırakılamaz");
            RuleFor(s => s.MudurlukSeriNo).NotEmpty().WithMessage("Müdürlük Seri No İsmi Boş Bırakılamaz");
            // RuleFor(x => x.MudurlukSeriNo).Must(IsUnique).WithMessage("Sistem No benzersiz olmalı!!!").WithSeverity(Severity.Warning);
            // RuleFor(x => x.MudurlukIsim).Must(IsUniqueIsim).WithMessage("Müdürlük ismi benzersiz olmalı!!!").WithSeverity(Severity.Warning);
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