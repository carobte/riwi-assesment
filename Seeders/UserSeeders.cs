using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_CarolinaBustamante.Config;
using Assessment_CarolinaBustamante.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment_CarolinaBustamante.Seeders
{
    public class UserSeeders

    {
        protected readonly Utilities _utilities;

        public UserSeeders(Utilities utilities)
        {
            _utilities = utilities;
        }

        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FullName = "juan perez",
                    Email = "juan.perez@email.com",
                    Password = _utilities.EncryptSHA256("password"),
                    Role = "doctor",
                },
                new User
                {
                    Id = 2,
                    FullName = "ana gomez",
                    Email = "ana.gomez@email.com",
                    Password = _utilities.EncryptSHA256("password"),
                    Role = "patient",
                },
                new User
                {
                    Id = 3,
                    FullName = "carlos rodriguez",
                    Email = "carlos.rodriguez@email.com",
                    Password = _utilities.EncryptSHA256("password"),
                    Role = "doctor",
                },
                new User
                {
                    Id = 4,
                    FullName = "laura martinez",
                    Email = "laura.martinez@email.com",
                    Password = _utilities.EncryptSHA256("password"),
                    Role = "patient",
                },
                new User
                {
                    Id = 5,
                    FullName = "pedro sanchez",
                    Email = "pedro.sanchez@email.com",
                    Password = _utilities.EncryptSHA256("password"),
                    Role = "doctor",
                },
                new User
                {
                    Id = 6,
                    FullName = "maria lopez",
                    Email = "maria.lopez@email.com",
                    Password = _utilities.EncryptSHA256("password"),
                    Role = "patient",
                },
                new User
                {
                    Id = 7,
                    FullName = "jose garcia",
                    Email = "jose.garcia@email.com",
                    Password = _utilities.EncryptSHA256("password"),
                    Role = "doctor",
                },
                new User
                {
                    Id = 8,
                    FullName = "isabel fernandez",
                    Email = "isabel.fernandez@email.com",
                    Password = _utilities.EncryptSHA256("password"),
                    Role = "patient",
                },
                new User
                {
                    Id = 9,
                    FullName = "david martinez",
                    Email = "david.martinez@email.com",
                    Password = _utilities.EncryptSHA256("password"),
                    Role = "doctor",
                },
                new User
                {
                    Id = 10,
                    FullName = "marta rodriguez",
                    Email = "marta.rodriguez@email.com",
                    Password = _utilities.EncryptSHA256("password"),
                    Role = "patient",
                },
                new User
                {
                    Id = 11,
                    FullName = "alejandro torres",
                    Email = "alejandro.torres@email.com",
                    Password = _utilities.EncryptSHA256("password"),
                    Role = "doctor",
                },
                new User
                {
                    Id = 12,
                    FullName = "silvia perez",
                    Email = "silvia.perez@email.com",
                    Password = _utilities.EncryptSHA256("password"),
                    Role = "patient",
                },
                new User
                {
                    Id = 13,
                    FullName = "felipe garcia",
                    Email = "felipe.garcia@email.com",
                    Password = _utilities.EncryptSHA256("password"),
                    Role = "doctor",
                },
                new User
                {
                    Id = 14,
                    FullName = "carla romero",
                    Email = "carla.romero@email.com",
                    Password = _utilities.EncryptSHA256("password"),
                    Role = "patient",
                },
                new User
                {
                    Id = 15,
                    FullName = "jorge jimenez",
                    Email = "jorge.jimenez@email.com",
                    Password = _utilities.EncryptSHA256("password"),
                    Role = "doctor",
                },
                new User
                {
                    Id = 16,
                    FullName = "luis moreno",
                    Email = "luis.moreno@email.com",
                    Password = _utilities.EncryptSHA256("password"),
                    Role = "patient",
                },
                new User
                {
                    Id = 17,
                    FullName = "patricia ramirez",
                    Email = "patricia.ramirez@email.com",
                    Password = _utilities.EncryptSHA256("password"),
                    Role = "doctor",
                },
                new User
                {
                    Id = 18,
                    FullName = "manuel diaz",
                    Email = "manuel.diaz@email.com",
                    Password = _utilities.EncryptSHA256("password"),
                    Role = "patient",
                },
                new User
                {
                    Id = 19,
                    FullName = "carmen castro",
                    Email = "carmen.castro@email.com",
                    Password = _utilities.EncryptSHA256("password"),
                    Role = "doctor",
                },
                new User
                {
                    Id = 20,
                    FullName = "jorge ruiz",
                    Email = "jorge.ruiz@email.com",
                    Password = _utilities.EncryptSHA256("password"),
                    Role = "patient",
                }
            );
        }
    }
}
