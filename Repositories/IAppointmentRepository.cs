using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_CarolinaBustamante.DTO;

namespace Assessment_CarolinaBustamante.Repositories
{
    public interface IAppointmentRepository
    {
        Task<IEnumerable<AppointmentDTO>> GetAppointments();
    
    }
}