using System;
using System.ComponentModel.DataAnnotations;
namespace Retreat_Management_System.web.Data
{
    public class User
    {
        public int UserID { get; set; }

        
        [StringLength(255)]
        public required string Username { get; set; }

        
        [StringLength(255)]
        public required string Password { get; set; }

        
        [StringLength(255)]
        public required string Email { get; set; }

        
        public string Role { get; set; } = "User"; // Default role set to "User"

        
        [StringLength(255)]
        public required string FirstName { get; set; }

       
        [StringLength(255)]
        public required string LastName { get; set; }

        public string? ProfilePicture { get; set; } 
        public string? ContactInfo { get; set; } 

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime? LastLogin { get; set; }
    }
}
