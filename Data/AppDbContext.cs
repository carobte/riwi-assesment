using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_CarolinaBustamante.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment_CarolinaBustamante.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Patient>() // Unique restriction for patient email in database
                .HasIndex(p => p.Email)
                .IsUnique();
            
            modelBuilder.Entity<Doctor>() // Unique restriction for doctor email in database
                .HasIndex(d => d.Email)
                .IsUnique();
        }
    }
}