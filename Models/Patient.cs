using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_CarolinaBustamante.Models
{
    [Table("patients")]
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("telephone")]
        public string Telephone { get; set; }

        [ForeignKey(nameof(User))]
        [Column("user_id")]
        public required int UserId { get; set; }
        public User User { get; set; }
    }
}