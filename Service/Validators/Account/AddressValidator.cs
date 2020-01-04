using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Store.Domain.Entities.Account;

namespace Store.Service.Validators.Account
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {

            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x => throw new ArgumentNullException($"Can't found the object"));

            RuleFor(c => c.State)
                .NotEmpty().WithMessage("Is necessary to inform the State.")
                .NotNull().WithMessage("Is necessary to inform the State.");

            RuleFor(c => c.City)
                .NotEmpty().WithMessage("Is necessary to inform the City.")
                .NotNull().WithMessage("Is necessary to inform the City.");

            RuleFor(c => c.Complement)
                .NotEmpty().WithMessage("Is necessary to inform the Complement.")
                .NotNull().WithMessage("Is necessary to inform the Complement.");

            RuleFor(c => c.Country)
                .NotEmpty().WithMessage("Is necessary to inform the Country.")
                .NotNull().WithMessage("Is necessary to inform the Country.");

            RuleFor(c => c.Neighborhood)
                .NotEmpty().WithMessage("Is necessary to inform the Neighborhood.")
                .NotNull().WithMessage("Is necessary to inform the Neighborhood.");

            RuleFor(c => c.Number)
                .NotEmpty().WithMessage("Is necessary to inform the Number.")
                .NotNull().WithMessage("Is necessary to inform the Number.");

            RuleFor(c => c.Street)
                .NotEmpty().WithMessage("Is necessary to inform the Street.")
                .NotNull().WithMessage("Is necessary to inform the Street.");

            RuleFor(c => c.ZipCode)
                .NotEmpty().WithMessage("Is necessary to inform the ZipCode.")
                .NotNull().WithMessage("Is necessary to inform the ZipCode.");
        }

    }
}
