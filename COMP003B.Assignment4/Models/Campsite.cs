using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models;

public class Campsite
{
    public int Id { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Name cannot be longer than 100 charecters.")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [StringLength(100, ErrorMessage = "Location can not be longer tha 100 charecters.")]
    public string Location { get; set; } = string.Empty;
    
    [Required]
    [Range(1, 16, ErrorMessage = "Max Occupancy must be between 1 and 20.")]
    public int MaxOccupancy { get; set; }
    
    [Required]
    [Range(1.00, 300.00, ErrorMessage = "Price per night must be between $1.00 and $300.00.")]
}