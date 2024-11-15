using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_CarolinaBustamante.Config;
using Assessment_CarolinaBustamante.Data;
using Assessment_CarolinaBustamante.DTO;
using Assessment_CarolinaBustamante.Models;
using Assessment_CarolinaBustamante.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Assessment_CarolinaBustamante.Services
{
    public class UserService : IUserRepository
    {
        private readonly AppDbContext _context;
        private readonly Utilities _utilities;

        public UserService(AppDbContext context, Utilities utilities)
        {
            _context = context;
            _utilities = utilities;
        }
        public async Task<(bool IsSuccess, string Message)> Register(UserRegistrationDTO userDTO)
        {
            var user = new User
            {
                FullName = userDTO.FullName,
                Email = userDTO.Email.ToLower(),
                Password = _utilities.EncryptSHA256(userDTO.Password),
                Role = userDTO.Role.ToLower()
            };

            var userExists =  await _context.Users.FirstOrDefaultAsync(u => u.Email == userDTO.Email.ToLower());

            if (userExists != null) {
                return (false, "The email is already registered. Please use a different email.");
            }

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            if (userDTO.Role == "doctor")
            {
                var doctor = new Doctor
                {
                    StartTime = userDTO.StartTime,
                    EndTime = userDTO.EndTime,
                    UserId = user.Id
                };

                _context.Doctors.Add(doctor);
            }

            else if (userDTO.Role == "doctor")
            {
                var patient = new Patient
                {
                    Telephone = userDTO.Telephone,
                    UserId = user.Id
                };

                _context.Patients.Add(patient);
            }

            _context.SaveChanges();
            return (true, "User registered successfully.");
        }

        public async Task<IEnumerable<DoctorDTO>> GetDoctors(){
            
            var doctors = await _context.Doctors
            .Include(doctor => doctor.User)
            .Select(doctor => new DoctorDTO {
                FullName = doctor.User.FullName,
                Email = doctor.User.Email,
                StartTime = doctor.StartTime,
                EndTime = doctor.EndTime
            }).ToListAsync();

            return doctors;
        }
   }
}