using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_CarolinaBustamante.DTO
{
    public class DoctorDTO
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public TimeOnly StartTime { get; set; } 
        public TimeOnly EndTime { get; set; } 

    }
}