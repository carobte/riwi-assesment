using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_CarolinaBustamante.Config;
using Assessment_CarolinaBustamante.Models;
using Assessment_CarolinaBustamante.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Assessment_CarolinaBustamante.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var utilities = new Utilities();
            var userSeeders = new UserSeeders(utilities);
            
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>() // Unique restriction for user email in database
                .HasIndex(u => u.Email)
                .IsUnique();

            userSeeders.Seed(modelBuilder);
            DoctorSeeders.Seed(modelBuilder);
            PatientSeeders.Seed(modelBuilder);

        }
    }
}