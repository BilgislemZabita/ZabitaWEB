using FluentValidation;
using Zabita.DataAccessLayer.Validation.Abstract.Validation.MobilValidation;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Validation.Conrete.Validation.MobilValidation
{
    public class FotoValidator : AbstractValidator<Foto>, IFotoValidator
    {
        public FotoValidator()
        {
            RuleFor(x => x.FotoAdi).NotEmpty().WithMessage("Fotoğraf ismini boş bırakma!!");
        }
    }
}