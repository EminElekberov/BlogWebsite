using Entity.Concencrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Ad soyad bos ola bilmez");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Mail adresi bos ola bilmez");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Sifre bos ola bilmez");
        }
    }
}
