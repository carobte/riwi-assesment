using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_CarolinaBustamante.DTO
{
    public class AppointmentRequest
    {
        public string Reason { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
    }
}