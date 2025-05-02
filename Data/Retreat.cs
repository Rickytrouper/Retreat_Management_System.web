using System;
using System.ComponentModel.DataAnnotations;
namespace Retreat_Management_System.web.Data;

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
    public DateTime StartDate { get; set; }

    [Required]
    public DateTime EndDate { get; set; }

    [Required]
    [Range(0, double.MaxValue)]
    public decimal Price { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Capacity { get; set; }

    public string? ImageURL { get; set; }
    public required string ContactInfo { get; set; }

    public int? CreatedBy { get; set; }
    public int? OrganizerID { get; set; }

    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
}
