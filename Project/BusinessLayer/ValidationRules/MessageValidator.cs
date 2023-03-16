using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı adresini boş bırakmayınız");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş bırakmayınız");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı boş bırakmayınız");
            RuleFor(x => x.ReceiverMail).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.ReceiverMail).MaximumLength(100).WithMessage("Lütfen 100 ' den fazla karakter girişi yapmayınız.");
            
        
        }
    }
}
