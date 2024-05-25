using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.RangeRepository.Validation
{
    public class RangeValidator:AbstractValidator<Entities.Concrete.Range>
    {
        public RangeValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name cannot be empty");
        }
    }
}