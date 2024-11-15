using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_CarolinaBustamante.Models
{
    [Table("doctors")]
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Start time is required.")]
        [Column("start_time", TypeName = "time")]
        public required TimeOnly StartTime { get; set; }

        [Required(ErrorMessage = "End time is required.")]
        [Column("end_time", TypeName = "time")]
        public required TimeOnly EndTime { get; set; }

        [ForeignKey(nameof(User))]
        [Column("user_id")]
        public required int UserId { get; set; }
        public User User { get; set; }
    }
}