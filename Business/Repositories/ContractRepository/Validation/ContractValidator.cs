using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.ContractRepository.Validation
{
    public class ContractValidator:AbstractValidator<Contract>
    {
        public ContractValidator()
        {
            RuleFor(p => p.SaleDate).NotEmpty().WithMessage("SaleDate cannot be empty");
            RuleFor(p => p.Number).NotEmpty().WithMessage("Number cannot be empty");
            RuleFor(p => p.ClientId).NotEmpty().WithMessage("ClientId cannot be empty");
            RuleFor(p => p.ProductId).NotEmpty().WithMessage("ProductId cannot be empty");
            RuleFor(p => p.TotalEffectivePayment).NotEmpty().WithMessage("TotalEffectivePayment cannot be empty");
            RuleFor(p => p.Quantity).NotEmpty().WithMessage("Quantity cannot be empty");
            RuleFor(p => p.StatedPriceCharged).NotEmpty().WithMessage("StatedPriceCharged cannot be empty");
            RuleFor(p => p.TotalSalesAmount).NotEmpty().WithMessage("TotalSalesAmount cannot be empty");
            RuleFor(p => p.NetAmount).NotEmpty().WithMessage("NetAmount cannot be empty");
            RuleFor(p => p.BaseAmountForCommission).NotEmpty().WithMessage("BaseAmountForCommission cannot be empty");
            RuleFor(p => p.PaymentMethodId).NotEmpty().WithMessage("PaymentMethodId cannot be empty");
            RuleFor(p => p.StateId).NotEmpty().WithMessage("StateId cannot be empty");
            RuleFor(p => p.RangeId).NotEmpty().WithMessage("RangeId cannot be empty");
        }
    }
}