using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Retreat_Management_System.web.Data
{
    public class Retreat
    {
        public int RetreatID { get; set; }

        [Required]
        [StringLength(255)]
        public required string RetreatName { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        [StringLength(255)]
        public required string Location { get; set; }

        [Required]
        public required DateTime StartDate { get; set; }

        [Required]
        public required DateTime EndDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")] 
        public required decimal Price { get; set; }

        [Required]
        public required int Capacity { get; set; }

    }
}
