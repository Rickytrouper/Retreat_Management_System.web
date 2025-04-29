using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Retreat_Management_System.web.Data
{
    public class Payment
    {
        public int PaymentID { get; set; }

        [Required]
        public required int BookingID { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public required decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; } = DateTime.Now;

        [Required]
        [StringLength(50)]
        public required string PaymentMethod { get; set; } // "Credit Card", "PayPal", "Bank Transfer"

        [Required]
        [StringLength(20)]
        public required string Status { get; set; } // "Successful", "Failed", "Pending"
        public required Booking Booking { get; set; }

    }
}
