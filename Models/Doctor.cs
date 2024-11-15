using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_CarolinaBustamante.Models
{
    [Table("doctor")]
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(255, ErrorMessage = "Full name cannot exceed 255 characters.")]
        [Column("name")]
        public required string FullName { get; set; }

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [StringLength(255, ErrorMessage = "Email cannot exceed 255 characters.")]
        [Column("email")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [PasswordPropertyText]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Password must be between 4 and 100 characters long.")]
        [Column("password")]
        public required string Password { get; set; }

        [Required(ErrorMessage = "Start time is required.")]
        [Column("start_time", TypeName="time" )]
        public required TimeOnly StartTime { get; set; }

        [Required(ErrorMessage = "End time is required.")]
        [Column("end_time", TypeName="time" )]
        public required TimeOnly EndTime { get; set; }

        [Column("role")]
        [Required(ErrorMessage = "Role is required.")]
        [MaxLength(100)]
        public required string Role { get; set; }
    }
}