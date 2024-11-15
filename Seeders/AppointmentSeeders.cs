using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_CarolinaBustamante.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment_CarolinaBustamante.Seeders
{
    public class AppointmentSeeders
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment
                {
                    Id = 1,
                    Reason = "General consultation",
                    Date = new DateTime(2024, 11, 20, 9, 30, 0),
                    Status = "scheduled",
                    Notes = "First-time patient, check medical history.",
                    PatiendId = 1,
                    DoctorId = 2
                },
                new Appointment
                {
                    Id = 2,
                    Reason = "Blood pressure check",
                    Date = new DateTime(2024, 11, 21, 10, 0, 0),
                    Status = "scheduled",
                    Notes = "Patient has a history of hypertension.",
                    PatiendId = 2,
                    DoctorId = 3
                },
                new Appointment
                {
                    Id = 3,
                    Reason = "Abdominal pain",
                    Date = new DateTime(2024, 11, 22, 11, 15, 0),
                    Status = "completed",
                    Notes = "Possible gastritis, prescribed medication.",
                    PatiendId = 3,
                    DoctorId = 1
                },
                new Appointment
                {
                    Id = 4,
                    Reason = "Annual check-up",
                    Date = new DateTime(2024, 11, 23, 14, 45, 0),
                    Status = "scheduled",
                    Notes = "",
                    PatiendId = 4,
                    DoctorId = 4
                },
                new Appointment
                {
                    Id = 5,
                    Reason = "Dermatology consultation",
                    Date = new DateTime(2024, 11, 24, 16, 0, 0),
                    Status = "cancelled",
                    Notes = "Patient canceled due to personal reasons.",
                    PatiendId = 5,
                    DoctorId = 5
                },
                new Appointment
                {
                    Id = 6,
                    Reason = "Follow-up on blood tests",
                    Date = new DateTime(2024, 11, 25, 13, 30, 0),
                    Status = "scheduled",
                    Notes = "Review lab results and discuss next steps.",
                    PatiendId = 6,
                    DoctorId = 2
                },
                new Appointment
                {
                    Id = 7,
                    Reason = "Flu symptoms",
                    Date = new DateTime(2024, 11, 26, 9, 0, 0),
                    Status = "completed",
                    Notes = "Prescribed antiviral medication.",
                    PatiendId = 7,
                    DoctorId = 3
                },
                new Appointment
                {
                    Id = 8,
                    Reason = "Pediatric consultation",
                    Date = new DateTime(2024, 11, 27, 10, 45, 0),
                    Status = "scheduled",
                    Notes = "Patient is a child, bring vaccination record.",
                    PatiendId = 8,
                    DoctorId = 4
                },
                new Appointment
                {
                    Id = 9,
                    Reason = "Diabetes management",
                    Date = new DateTime(2024, 11, 28, 15, 30, 0),
                    Status = "rescheduled",
                    Notes = "Patient requested to change the date.",
                    PatiendId = 9,
                    DoctorId = 1
                },
                new Appointment
                {
                    Id = 10,
                    Reason = "Physical therapy",
                    Date = new DateTime(2024, 11, 29, 8, 0, 0),
                    Status = "scheduled",
                    Notes = "Focus on lower back pain.",
                    PatiendId = 10,
                    DoctorId = 5
                }
            );
        }
    }
}