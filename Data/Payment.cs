using System;
using System.ComponentModel.DataAnnotations;
namespace Retreat_Management_System.web.Data
{
    public class Payment
    {
        public int PaymentID { get; set; }

        public int? BookingID { get; set; }

        
        [Range(0, double.MaxValue)]
        public required decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;

        
        [StringLength(50)]
        [RegularExpression(@"^(Credit Card|PayPal|Bank Transfer)$", ErrorMessage = "Invalid Payment Method")]
        public required string PaymentMethod { get; set; }

       
        [StringLength(20)]
        [RegularExpression(@"^(Successful|Failed|Pending)$", ErrorMessage = "Invalid Status")]
        public required  string Status { get; set; }

       
        [StringLength(255)]
        public required string TransactionID { get; set; }

    }
}
