using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Retreat_Management_System.web.Data
{
    public class Booking
    {
        public int BookingID { get; set; }

        [Required]
        public required int UserID { get; set; }

        [Required]
        public required int RetreatID { get; set; }

        public DateTime BookingDate { get; set; } = DateTime.Now;

        [Required]
        [StringLength(20)]
        public required string Status { get; set; } // "Confirmed", "Cancelled", "Pending"

        public required User User { get; set; }

        public required Retreat Retreat{ get; set; }
    }



}
