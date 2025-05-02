using System.ComponentModel.DataAnnotations;

namespace Retreat_Management_System.web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        public bool IsPersistent { get; set; } // Added for "Remember Me" functionality
    }
}