using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_CarolinaBustamante.Data;
using Assessment_CarolinaBustamante.DTO;
using Assessment_CarolinaBustamante.Models;
using Assessment_CarolinaBustamante.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Assessment_CarolinaBustamante.Services
{
    public class AppointmentService : IAppointmentRepository
    {

        private readonly AppDbContext _context;

        public AppointmentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<(bool IsSuccess, string Message)> CreateAppointment(AppointmentRequest appointment)
        {

            // Verify if that doctor is available in the specified date

            bool isDoctorOccupied = await _context.Appointments
                .AnyAsync(appt => appt.DoctorId == appointment.DoctorId
                               && appt.Date == appointment.Date);

            if (isDoctorOccupied)
            {
                return (false, "The selected doctor is unavailable at this time. Please choose another doctor or a different time.");
            }
            
            var newApointment = new Appointment
                {
                    Reason = appointment.Reason,
                    Date = appointment.Date,
                    Status = "Scheduled",
                    Notes = appointment.Notes,
                    PatiendId = appointment.PatientId,
                    DoctorId = appointment.DoctorId
                };

                _context.Appointments.Add(newApointment);
                await _context.SaveChangesAsync();
                return(true, "The appointment has been scheduled");
            }

        public async Task<IEnumerable<AppointmentDTO>> GetAppointments()
        {
            var appointments = await _context.Appointments
            .Include(appt => appt.Patient)
                .ThenInclude(patient => patient.User)
            .Include(appt => appt.Doctor)
                .ThenInclude(doctor => doctor.User)
            .ToListAsync();

            return appointments.Select(appt => new AppointmentDTO
            {
                Id = appt.Id,
                Date = appt.Date,
                Status = appt.Status,
                Notes = appt.Notes,
                Patient = appt.Patient.User.FullName,
                PatientEmail = appt.Patient.User.Email,
                PatientTelephone = appt.Patient.Telephone,
                Doctor = appt.Doctor.User.FullName,
                Reason = appt.Reason
            });
        }
    }
}