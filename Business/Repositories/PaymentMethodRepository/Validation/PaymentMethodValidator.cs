using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.PaymentMethodRepository.Validation
{
    public class PaymentMethodValidator:AbstractValidator<PaymentMethod>
    {
        public PaymentMethodValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name cannot be empty");
        }
    }
}