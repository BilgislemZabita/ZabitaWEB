using FluentValidation;
using Zabita.DataAccessLayer.Validation.Abstract.Validation.MobilValidation;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Validation.Conrete.Validation.MobilValidation
{
    public class TeknikBilgilerValidator : AbstractValidator<YerleskeTeknikBilgiler>, ITeknikBilgilerValidator
    {
        public TeknikBilgilerValidator()
        {
            /*RuleFor(x => x.InsaatTipi).NotEmpty().WithMessage("İnşaat Tipi Bilgisini Boş Bırakmayın!!");
            RuleFor(x => x.AlanBilgisi).NotEmpty().WithMessage("Alan Bilgisini Boş Bırakmayın!!");
            RuleFor(x => x.Uzunluk).NotEmpty().WithMessage("Uzunluk Bilgisini Boş Bırakmayın!!");
            RuleFor(x => x.Genislik).NotEmpty().WithMessage("Genişlik Bilgisini Boş Bırakmayın!!");
            RuleFor(x => x.ZeminBilgisi).NotEmpty().WithMessage("Zemin Bilgisini Boş Bırakmayın!!");
            RuleFor(x => x.KatBilgisi).NotEmpty().WithMessage("Kat Bilgisini Boş Bırakmayın!!");

            RuleFor(x => x.Aydinlatma).NotEmpty().WithMessage("Aydınlatma Bilgisini Boş Bırakmayın!!");
            RuleFor(x => x.CatiTipi).NotEmpty().WithMessage("Çatı Tipi Bilgisini Boş Bırakmayın!!");
*/
        }
    }
}