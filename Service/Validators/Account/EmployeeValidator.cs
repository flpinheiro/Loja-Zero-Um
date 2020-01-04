using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Store.Domain.Entities.Account;

namespace Store.Service.Validators.Account
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x => throw new ArgumentNullException($"Can't found the object"));

            RuleFor(c => c.Registration)
                .NotEmpty().WithMessage("Is necessary to inform the Registration.")
                .NotNull().WithMessage("Is necessary to inform the Registration.");

            RuleFor(c => c.Salary)
                .NotEmpty().WithMessage("Is necessary to inform the Salary.")
                .NotNull().WithMessage("Is necessary to inform the Salary.");
        }
    }
}
