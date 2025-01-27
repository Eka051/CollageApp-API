using CollegeApp.Models.Validators;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Models
{
    public class StudentDTO
    {
        [ValidateNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "Student Name is Required. Fill this field!")]
        [StringLength(50, MinimumLength = 2)]
        public string StudentName { get; set; }

        [EmailAddress(ErrorMessage = "Please enter valid email address (user@example.com)")]
        public string Email { get; set; }

        [Range(16,30)]
        public int age { get; set; }

        [Required(ErrorMessage = "Address is Required")]
        [StringLength(100, MinimumLength = 5)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [StringLength(20, MinimumLength = 3)]
        public string Password { get; set; }

        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        [DateCheck]
        public DateTime AdmissionDate { get; set; }

    }
}
