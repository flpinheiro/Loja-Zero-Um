using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Store.Domain.Entities.Account;

namespace Store.Service.Validators.Account
{
    public class PhoneValidator : AbstractValidator<Phone>
    {
        public PhoneValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x => throw new ArgumentNullException($"Can't found the object"));

            RuleFor(c => c.Number)
                .NotEmpty().WithMessage("Is necessary to inform the Phone Number.")
                .NotNull().WithMessage("Is necessary to inform the Phone Number.");

            RuleFor(c => c.AreaCode)
                .NotEmpty().WithMessage("Is necessary to inform the Area Code.")
                .NotNull().WithMessage("Is necessary to inform the Area Code.");

            RuleFor(c => c.CountryCode)
                .NotEmpty().WithMessage("Is necessary to inform the Country Code.")
                .NotNull().WithMessage("Is necessary to inform the Country Codes.");
        }
    }
}
