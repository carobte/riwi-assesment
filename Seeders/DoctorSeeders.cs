using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_CarolinaBustamante.Config;
using Assessment_CarolinaBustamante.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment_CarolinaBustamante.Seeders
{
    public class DoctorSeeders
    {
        protected readonly Utilities _utilities;

        public DoctorSeeders(Utilities utilities)
        {
            _utilities = utilities;
        }

        public void Seed(ModelBuilder modelBuilder){
            modelBuilder.Entity<Doctor>().HasData(
            new Doctor
            {
                Id = 1,
                FullName = "roberto martinez",
                Email = "roberto.martinez@email.com",
                Password = _utilities.EncryptSHA256("password"),
                StartTime = new TimeOnly(7, 0),
                EndTime = new TimeOnly(15, 0),
                Role = "doctor",
            },
            new Doctor
            {
                Id = 2,
                FullName = "patricia ortega",
                Email = "patricia.ortega@email.com",
                Password = _utilities.EncryptSHA256("password"),
                StartTime = new TimeOnly(8, 0),
                EndTime = new TimeOnly(16, 0),
                Role = "doctor",
            },
            new Doctor
            {
                Id = 3,
                FullName = "josefina ruiz",
                Email = "josefina.ruiz@email.com",
                Password = _utilities.EncryptSHA256("password"),
                StartTime = new TimeOnly(9, 0),
                EndTime = new TimeOnly(17, 0),
                Role = "doctor",
            },
            new Doctor
            {
                Id = 4,
                FullName = "fernando lopez",
                Email = "fernando.lopez@email.com",
                Password = _utilities.EncryptSHA256("password"),
                StartTime = new TimeOnly(7, 30),
                EndTime = new TimeOnly(15, 30),
                Role = "doctor",
            },
            new Doctor
            {
                Id = 5,
                FullName = "maria garcia",
                Email = "maria.garcia@email.com",
                Password = _utilities.EncryptSHA256("password"),
                StartTime = new TimeOnly(8, 30),
                EndTime = new TimeOnly(16, 30),
                Role = "doctor",
            },
            new Doctor
            {
                Id = 6,
                FullName = "luis hernandez",
                Email = "luis.hernandez@email.com",
                Password = _utilities.EncryptSHA256("password"),
                StartTime = new TimeOnly(10, 0),
                EndTime = new TimeOnly(18, 0),
                Role = "doctor",
            },
            new Doctor
            {
                Id = 7,
                FullName = "elena diaz",
                Email = "elena.diaz@email.com",
                Password = _utilities.EncryptSHA256("password"),
                StartTime = new TimeOnly(6, 30),
                EndTime = new TimeOnly(14, 30),
                Role = "doctor",
            },
            new Doctor
            {
                Id = 8,
                FullName = "juana perez",
                Email = "juana.perez@email.com",
                Password = _utilities.EncryptSHA256("password"),
                StartTime = new TimeOnly(9, 30),
                EndTime = new TimeOnly(17, 30),
                Role = "doctor",
            },
            new Doctor
            {
                Id = 9,
                FullName = "carmen martinez",
                Email = "carmen.martinez@email.com",
                Password = _utilities.EncryptSHA256("password"),
                StartTime = new TimeOnly(7, 0),
                EndTime = new TimeOnly(15, 0),
                Role = "doctor",
            },
            new Doctor
            {
                Id = 10,
                FullName = "alejandro fernandez",
                Email = "alejandro.fernandez@email.com",
                Password = _utilities.EncryptSHA256("password"),
                StartTime = new TimeOnly(8, 0),
                EndTime = new TimeOnly(16, 0),
                Role = "doctor",
            });
        }
    }
}