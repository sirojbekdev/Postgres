using FluentValidation;
using Posgres.Entities;

namespace Posgres.Validators
{
    public class RoleValidator : AbstractValidator<Role>
    {
        public RoleValidator()
        {
            RuleFor(x => x.Id).NotNull().NotEmpty();
            RuleFor(x => x.Name).NotNull().MaximumLength(50);
        }
    }
}
