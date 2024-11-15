using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_CarolinaBustamante.Models
{
    [Table("appointment")]
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Reason is required.")]
        [StringLength(255, ErrorMessage = "Reason cannot exceed 255 characters.")]
        [Column("reason")]
        public required string Reason { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        [Column("status")]
        public string Status { get; set; }

        [Column("notes")]
        public string Notes { get; set; }

        [ForeignKey(nameof(Patient))]
        [Column("patient_id")]
        public required int PatiendId { get; set; }
        public Patient Patient { get; set; }

        [ForeignKey(nameof(Doctor))]
        [Column("doctor_id")]
        public required int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}