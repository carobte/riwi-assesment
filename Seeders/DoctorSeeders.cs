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
        public static void Seed(ModelBuilder modelBuilder){
            modelBuilder.Entity<Doctor>().HasData(
            new Doctor
            {
                Id = 1,
                StartTime = new TimeOnly(7, 0),
                EndTime = new TimeOnly(15, 0),
                UserId = 1
            },
            new Doctor
            {
                Id = 2,
                StartTime = new TimeOnly(8, 0),
                EndTime = new TimeOnly(16, 0),
                UserId = 3
            },
            new Doctor
            {
                Id = 3,
                StartTime = new TimeOnly(9, 0),
                EndTime = new TimeOnly(17, 0),
                UserId = 5
            },
            new Doctor
            {
                Id = 4,
                StartTime = new TimeOnly(7, 30),
                EndTime = new TimeOnly(15, 30),
                UserId = 7
            },
            new Doctor
            {
                Id = 5,
                StartTime = new TimeOnly(8, 30),
                EndTime = new TimeOnly(16, 30),
                UserId = 9
            },
            new Doctor
            {
                Id = 6,
                StartTime = new TimeOnly(10, 0),
                EndTime = new TimeOnly(18, 0),
                UserId = 11
            },
            new Doctor
            {
                Id = 7,
                StartTime = new TimeOnly(6, 30),
                EndTime = new TimeOnly(14, 30),
                UserId = 13
            },
            new Doctor
            {
                Id = 8,
                StartTime = new TimeOnly(9, 30),
                EndTime = new TimeOnly(17, 30),
                UserId = 15
            },
            new Doctor
            {
                Id = 9,
                StartTime = new TimeOnly(7, 0),
                EndTime = new TimeOnly(15, 0),
                UserId = 17
            },
            new Doctor
            {
                Id = 10,
                StartTime = new TimeOnly(8, 0),
                EndTime = new TimeOnly(16, 0),
                UserId = 19
            });
        }
    }
}