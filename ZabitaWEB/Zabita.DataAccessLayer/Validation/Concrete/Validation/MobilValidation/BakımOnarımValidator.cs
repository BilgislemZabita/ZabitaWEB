using FluentValidation;
using Zabita.DataAccessLayer.Validation.Abstract.Validation.MobilValidation;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Validation.Conrete.Validation.MobilValidation
{
    public class BakımOnarımValidator : AbstractValidator<YerleskeBakimOnarim>, IBakımOnarımValidator
    {
        public BakımOnarımValidator()
        {
            RuleFor(x => x.BoyamaTarih).NotEmpty().WithMessage("boş bırakma");
            RuleFor(x => x.ElektrikBakimTarih).NotEmpty().WithMessage("boş bırakma");
            RuleFor(x => x.SihhiTesisatBakimTarih).NotEmpty().WithMessage("boş bırakma");
        }
    }
}