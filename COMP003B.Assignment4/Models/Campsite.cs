using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models;

public class Campsite
{
    public int Id { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Name cannot be longer than 100 charecters.")]
    public string Name { get; set; } = string.Empty;
}