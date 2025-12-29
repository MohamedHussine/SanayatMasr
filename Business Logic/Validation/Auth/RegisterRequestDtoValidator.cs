using BusinessLogic.Constants;
using BusinessLogic.DTOs.Auth;
using FluentValidation;

namespace BusinessLogic.Validation.Auth
{
    public class RegisterRequestDtoValidator
        : AbstractValidator<RegisterRequestDTO>
    {
        public RegisterRequestDtoValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("Full name is required")
                .MinimumLength(3).WithMessage("Full name must be at least 3 characters");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Invalid email format");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters")
                .Matches("[A-Z]").WithMessage("Password must contain at least one uppercase letter")
                .Matches("[a-z]").WithMessage("Password must contain at least one lowercase letter")
                .Matches("[0-9]").WithMessage("Password must contain at least one number");

            // 🔴 أهم Validation
            RuleFor(x => x.Role)
                .NotEmpty().WithMessage("Role is required")
                .Must(role => Roles.AllowedRegisterRoles.Contains(role))
                .WithMessage("Role must be Customer or Craftsman");

            RuleFor(x => x.GovernorateId)
                .GreaterThan(0).WithMessage("Governorate is required");

            RuleFor(x => x.CityId)
                .GreaterThan(0).WithMessage("City is required");
        }
    }
}
