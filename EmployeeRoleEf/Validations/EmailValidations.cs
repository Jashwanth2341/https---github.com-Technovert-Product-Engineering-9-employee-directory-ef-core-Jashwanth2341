
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace EmployeeRoleEf.CustomValidations;
public class CustomEmailAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null)
        {
            var email = value.ToString();
            var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (email is null)
            {
                return new ValidationResult("Invalid email address.");
            }
            if (!regex.IsMatch(email))
            {
                return new ValidationResult("Invalid email address.");
            }
        }
        return ValidationResult.Success;
    }
}
