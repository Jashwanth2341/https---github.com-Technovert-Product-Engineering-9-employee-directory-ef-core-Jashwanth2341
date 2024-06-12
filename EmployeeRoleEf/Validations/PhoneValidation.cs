
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace EmployeeRoleEf.CustomValidations;

public class CustomPhoneAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null)
        {
            var phone = value.ToString();
            var Regex = new Regex(@"^\+?\d{10,12}$");
            if (phone is null)
            {
                return new ValidationResult("Invalid phone number.");
            }

            if (!Regex.IsMatch(phone))
            {
                return new ValidationResult("Invalid phone number.");
            }
        }
        return ValidationResult.Success;
    }

}
