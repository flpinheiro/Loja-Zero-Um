using System;
using FluentValidation;
using Store.Domain.Entities.Account;

namespace Store.Service.Validators.Account
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x => throw new ArgumentNullException($"Can't found the object"));

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Is necessary to inform the Email.")
                .NotNull().WithMessage("Is necessary to inform the Email.");

            RuleFor(c => c.PassWord)
                .NotEmpty().WithMessage("Is necessary to inform the password.")
                .NotNull().WithMessage("Is necessary to inform the password.");
        }
    }
}
