using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_CarolinaBustamante.DTO
{
public class UserRegistrationDTO
{
    [Required]
    [StringLength(255)]
    public required string FullName { get; set; }

    [Required]
    [EmailAddress]
    [StringLength(255)]
    public required string Email { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 4)]
    public required string Password { get; set; }

    [Required]
    [MaxLength(100)]
    public required string Role { get; set; } // "doctor" o "patient"
    
    // Depending of the rol, optionals:
    public string Telephone { get; set; } // Pacients
    public TimeOnly StartTime { get; set; } // Doctor
    public TimeOnly EndTime { get; set; } // Doctor
}

}