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
        protected readonly Utilities _utilities;

        public PatientSeeders(Utilities utilities)
        {
            _utilities = utilities;
        }

        public void Seed(ModelBuilder modelBuilder) // No static so _utilities can be properly used.
        {
            modelBuilder.Entity<Patient>().HasData(
            new Patient
            {
                 Id = 1,
                 FullName = "juan perez",
                 Email = "juan.perez@email.com",
                 Password = _utilities.EncryptSHA256("password"),
                 Role = "pacient",
            },
            new Patient
            {
                Id = 2,
                FullName = "ana gomez",
                Email = "ana.gomez@email.com",
                Password = _utilities.EncryptSHA256("password"),
                Role = "pacient",
            },
            new Patient
            {
                Id = 3,
                FullName = "carlos rodriguez",
                Email = "carlos.rodriguez@email.com",
                Password = _utilities.EncryptSHA256("password"),
                Role = "pacient",
            },
            new Patient
            {
                Id = 4,
                FullName = "laura martinez",
                Email = "laura.martinez@email.com",
                Password = _utilities.EncryptSHA256("password"),
                Role = "pacient",
            },
            new Patient
            {
                Id = 5,
                FullName = "pedro sanchez",
                Email = "pedro.sanchez@email.com",
                Password = _utilities.EncryptSHA256("password"),
                Role = "pacient",
            },
            new Patient
            {
                Id = 6,
                FullName = "maria lopez",
                Email = "maria.lopez@email.com",
                Password = _utilities.EncryptSHA256("password"),
                Role = "pacient",
            },
            new Patient
            {
                Id = 7,
                FullName = "jose garcia",
                Email = "jose.garcia@email.com",
                Password = _utilities.EncryptSHA256("password"),
                Role = "pacient",
            },
            new Patient
            {
                Id = 8,
                FullName = "isabel fernandez",
                Email = "isabel.fernandez@email.com",
                Password = _utilities.EncryptSHA256("password"),
                Role = "pacient",
            },
            new Patient
            {
                Id = 9,
                FullName = "david martinez",
                Email = "david.martinez@email.com",
                Password = _utilities.EncryptSHA256("password"),
                Role = "pacient",
            },
            new Patient
            {
                Id = 10,
                FullName = "marta rodriguez",
                Email = "marta.rodriguez@email.com",
                Password = _utilities.EncryptSHA256("password"),
                Role = "pacient",
            }
            );

        }
    }
}