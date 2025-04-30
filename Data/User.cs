using System.ComponentModel.DataAnnotations;
namespace Retreat_Management_System.web.Data

{
    public class User
    {
         // Unique identifier for the user
    public int UserID { get; set; }

    // Required username for user login (max length: 50)
    [Required]
    [StringLength(50, ErrorMessage = "Username cannot be longer than 50 characters.")]
    public required string Username { get; set; }

    // Hashed password for secure authentication (max length: 255)
    [Required]
    [StringLength(255, ErrorMessage = "Password cannot be longer than 255 characters.")]
    public required string Password { get; set; }

    // Required email address, must be unique (max length: 100)
    [Required]
    [StringLength(100, ErrorMessage = "Email cannot be longer than 100 characters.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address.")]
    public required string Email { get; set; }

    // Required first name of the user (max length: 50)
    [Required]
    [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
    public required string FirstName { get; set; }

    // Required last name of the user (max length: 50)
    [Required]
    [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters.")]
    public required string LastName { get; set; }

    // Date when the user account was created
    public DateTime DateCreated { get; set; } = DateTime.Now;

    // Date of the last login, nullable
    public DateTime? LastLogin { get; set; }

    }
}
