using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş bırakmayınız");
            RuleFor(x => x.WriterLastName).NotEmpty().WithMessage("Yazar soy adını boş bırakmayınız");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmını boş bırakmayınız");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Ünvan kısmını boş bırakmayınız");
            RuleFor(x => x.WriterLastName).MinimumLength(2).WithMessage("Lütfen 2 karakterdan fazla değer girişi yapınız");
            RuleFor(x => x.WriterLastName).MaximumLength(20).WithMessage("Lütfen 20 karakterdan fazla değer girişi yapmayınız");

        }
    }
}
