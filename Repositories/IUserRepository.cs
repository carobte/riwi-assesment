using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_CarolinaBustamante.DTO;
using Assessment_CarolinaBustamante.Models;

namespace Assessment_CarolinaBustamante.Repositories
{
    public interface IUserRepository
    {
        Task<(bool IsSuccess, string Message)> Register(UserRegistrationDTO userRegistrationDTO);
        Task<IEnumerable<DoctorDTO>> GetDoctors();
        
    }
}