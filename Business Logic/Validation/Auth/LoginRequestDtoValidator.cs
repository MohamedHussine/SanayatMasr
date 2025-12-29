using BusinessLogic.DTOs.Auth;
using FluentValidation;

namespace BusinessLogic.Validation.Auth
{
    public class LoginRequestDtoValidator
        : AbstractValidator<LoginRequestDto>
    {
        public LoginRequestDtoValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.Password)
                .NotEmpty();
        }
    }
}
