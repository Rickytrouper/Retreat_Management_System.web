using System;
using System.ComponentModel.DataAnnotations;
namespace Retreat_Management_System.web.Data
{
    public class Booking
    {
        public int BookingID { get; set; }

        public int? UserID { get; set; }
        public int? RetreatID { get; set; }

        public DateTime BookingDate { get; set; } = DateTime.UtcNow;

        [StringLength(20)]
        [RegularExpression(@"^(Confirmed|Cancelled|Pending)$", ErrorMessage = "Invalid Status")]
        public required string Status { get; set; }

        [Required]
        [StringLength(255)]
        public required string UserName { get; set; }

        [Required]
        [StringLength(255)]
        public required string Email { get; set; }

        [Required]
        [StringLength(255)]
        public required string CardNumber { get; set; }

        [Required]
        public DateTime ExpiryDate { get; set; }

          
        [StringLength(10)]
        public required string CVV { get; set; }

        
        [StringLength(20)]
        [RegularExpression(@"^(Paid|Unpaid)$", ErrorMessage = "Invalid Payment Status")]
        public required string PaymentStatus { get; set; }


    }
}
