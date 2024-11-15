using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_CarolinaBustamante.DTO
{
    public class AppointmentDTO
    {
        public int Id { get; set; }
        public required string Reason { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public string Patient { get; set; }
        public string PatientEmail { get; set; }
        public string PatientTelephone { get; set; }
        public string Doctor { get; set; }
       
    }
}