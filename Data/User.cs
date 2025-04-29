using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Retreat_Management_System.web.Data
{
    public class User
    {
        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public required string Username { get; set; }

        [Required]
        [StringLength(255)]
        public required string PasswordHash { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [StringLength(50)]
        public required string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public required string LastName { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? LastLogin { get; set; }
    }
}
