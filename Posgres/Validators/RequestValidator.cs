using FluentValidation;
using Posgres.Models;

namespace Posgres.Validators
{
    public class RequestValidator : AbstractValidator<AuthenticateRequest>
    {
        public RequestValidator()
        {
            RuleFor(x => x.Email).NotNull().EmailAddress();
            RuleFor(x => x.Password).NotNull();
        }
    }
}
