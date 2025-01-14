using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Models
{
    public class StudentDTO
    {
        [ValidateNever]
        public int Id { get; set; }
        [Required(ErrorMessage = "Student Name is Required. Fill this field!")]
        public string StudentName { get; set; }
        [EmailAddress(ErrorMessage = "Please enter valid email address (user@example.com)")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Address is Required")]
        public string Address { get; set; }
    }
}
