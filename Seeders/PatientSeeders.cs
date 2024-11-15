using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_CarolinaBustamante.Config;
using Assessment_CarolinaBustamante.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment_CarolinaBustamante.Seeders
{
    public class PatientSeeders
    {
        public static void Seed(ModelBuilder modelBuilder) // No static so _utilities can be properly used.
        {
            modelBuilder.Entity<Patient>().HasData(
            new Patient
            {
                Id = 1,
                Telephone = "3001234567",
                UserId = 2
            },
            new Patient
            {
                Id = 2,
                Telephone = "3002345678",
                UserId = 4
            },
            new Patient
            {
                Id = 3,
                Telephone = "3003456789",
                UserId = 6
            },
            new Patient
            {
                Id = 4,
                Telephone = "3004567890",
                UserId = 8
            },
            new Patient
            {
                Id = 5,
                Telephone = "3005678901",
                UserId = 10
            },
            new Patient
            {
                Id = 6,
                Telephone = "3006789012",
                UserId = 12
            },
            new Patient
            {
                Id = 7,
                Telephone = "3007890123",
                UserId = 14
            },
            new Patient
            {
                Id = 8,
                Telephone = "3008901234",
                UserId = 16
            },
            new Patient
            {
                Id = 9,
                Telephone = "3009012345",
                UserId = 18
            },
            new Patient
            {
                Id = 10,
                Telephone = "3000123456",
                UserId = 20
            });
        }
    }
}