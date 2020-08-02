using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models.CustomValidators
{
    public class EmailDomainValidator : ValidationAttribute
    {
        public string AllowedDomain { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string[] strings = value.ToString().Split('@');
            if (strings[1].ToLower() == AllowedDomain.ToLower())
            {
                return null;
            }

            return new ValidationResult(ErrorMessage, new[]
            {
                validationContext.MemberName
            });
    }
    }
}