using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace BusinessLogic.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class RequiredIfRoleAttribute : ValidationAttribute
    {
        private readonly string _requiredRole;

        public RequiredIfRoleAttribute(string requiredRole)
        {
            _requiredRole = requiredRole;
        }

        protected override ValidationResult? IsValid(
            object? value,
            ValidationContext validationContext)
        {
            var roleProperty = validationContext.ObjectType
                .GetProperty("Role", BindingFlags.Public | BindingFlags.Instance);

            if (roleProperty == null)
                return ValidationResult.Success;

            var roleValue = roleProperty.GetValue(validationContext.ObjectInstance)
                ?.ToString();

            if (string.Equals(roleValue, _requiredRole, StringComparison.OrdinalIgnoreCase))
            {
                if (value == null)
                {
                    return new ValidationResult(
                        $"{validationContext.MemberName} is required when Role is {_requiredRole}");
                }
            }

            return ValidationResult.Success;
        }
    }
}
