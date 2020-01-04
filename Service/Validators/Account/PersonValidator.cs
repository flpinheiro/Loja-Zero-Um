using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Store.Domain.Entities.Account;

namespace Store.Service.Validators.Account
{
    public class PersonValidator :AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x => throw new ArgumentNullException($"Can't found the object"));

            RuleFor(c => c.FirstName)
                .NotEmpty().WithMessage("Is necessary to inform the First Name.")
                .NotNull().WithMessage("Is necessary to inform the First Name.");

            RuleFor(c => c.LastName)
                .NotEmpty().WithMessage("Is necessary to inform the Last Name.")
                .NotNull().WithMessage("Is necessary to inform the Last Name.");

            RuleFor(c => c.Birthday)
                .NotEmpty().WithMessage("Is necessary to inform the Birthday.")
                .NotNull().WithMessage("Is necessary to inform the Birthday.");
        }
    }
}
