using BusinessLogic.DTOs.Auth;
using FluentValidation;

namespace BusinessLogic.Validation.Auth
{
    public class RefreshTokenRequestDtoValidator
        : AbstractValidator<RefreshTokenRequestDto>
    {
        public RefreshTokenRequestDtoValidator()
        {
            RuleFor(x => x.RefreshToken).NotEmpty();
        }
    }
}
