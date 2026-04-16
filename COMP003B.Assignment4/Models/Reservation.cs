using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models;

public class Reservation
{
    public int Id { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "Campsite registration code cannot be longer than 20 charecters.")]
    public string CampsiteCode { get; set; } = string.Empty;

    [Required]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Guest name must be between 2 and 100 charecters.")]
    public string GuestName { get; set; } = string.Empty;

    [Required]
    [EmailAddress(ErrorMessage = "Valid email addresss required.")]
    public string Email { get; set; } = string.Empty;
    
    [Required]
    [Range(1,28, ErrorMessage = "Nights reserved must be between 1 and 28.")]
    public int Nights { get; set; }
    
    [Required]
    [Range(1, 16, ErrorMessage = "Guests for reservation must be between 1 and 16")]
    public int Guests { get; set; }
    
    [Required]
    [DataType(DataType.Date)]
    public DateTime ArrivalDate { get; set; }
}