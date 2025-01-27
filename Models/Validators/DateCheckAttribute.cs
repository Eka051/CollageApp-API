using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Models.Validators
{
    public class DateCheckAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var date = (DateTime?)value;

            if (date < DateTime.Now)
            {
                return new ValidationResult("Admission Date should be greater or equal to than current date");
            }
            return ValidationResult.Success;
        }
    }
}
