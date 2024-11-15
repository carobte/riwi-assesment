using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assessment_CarolinaBustamante.Migrations
{
    /// <inheritdoc />
    public partial class Seeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "email", "name", "password", "role" },
                values: new object[,]
                {
                    { 1, "juan.perez@email.com", "juan perez", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "doctor" },
                    { 2, "ana.gomez@email.com", "ana gomez", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "patient" },
                    { 3, "carlos.rodriguez@email.com", "carlos rodriguez", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "doctor" },
                    { 4, "laura.martinez@email.com", "laura martinez", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "patient" },
                    { 5, "pedro.sanchez@email.com", "pedro sanchez", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "doctor" },
                    { 6, "maria.lopez@email.com", "maria lopez", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "patient" },
                    { 7, "jose.garcia@email.com", "jose garcia", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "doctor" },
                    { 8, "isabel.fernandez@email.com", "isabel fernandez", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "patient" },
                    { 9, "david.martinez@email.com", "david martinez", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "doctor" },
                    { 10, "marta.rodriguez@email.com", "marta rodriguez", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "patient" },
                    { 11, "alejandro.torres@email.com", "alejandro torres", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "doctor" },
                    { 12, "silvia.perez@email.com", "silvia perez", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "patient" },
                    { 13, "felipe.garcia@email.com", "felipe garcia", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "doctor" },
                    { 14, "carla.romero@email.com", "carla romero", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "patient" },
                    { 15, "jorge.jimenez@email.com", "jorge jimenez", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "doctor" },
                    { 16, "luis.moreno@email.com", "luis moreno", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "patient" },
                    { 17, "patricia.ramirez@email.com", "patricia ramirez", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "doctor" },
                    { 18, "manuel.diaz@email.com", "manuel diaz", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "patient" },
                    { 19, "carmen.castro@email.com", "carmen castro", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "doctor" },
                    { 20, "jorge.ruiz@email.com", "jorge ruiz", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "patient" }
                });

            migrationBuilder.InsertData(
                table: "doctors",
                columns: new[] { "id", "end_time", "start_time", "user_id" },
                values: new object[,]
                {
                    { 1, new TimeOnly(15, 0, 0), new TimeOnly(7, 0, 0), 1 },
                    { 2, new TimeOnly(16, 0, 0), new TimeOnly(8, 0, 0), 3 },
                    { 3, new TimeOnly(17, 0, 0), new TimeOnly(9, 0, 0), 5 },
                    { 4, new TimeOnly(15, 30, 0), new TimeOnly(7, 30, 0), 7 },
                    { 5, new TimeOnly(16, 30, 0), new TimeOnly(8, 30, 0), 9 },
                    { 6, new TimeOnly(18, 0, 0), new TimeOnly(10, 0, 0), 11 },
                    { 7, new TimeOnly(14, 30, 0), new TimeOnly(6, 30, 0), 13 },
                    { 8, new TimeOnly(17, 30, 0), new TimeOnly(9, 30, 0), 15 },
                    { 9, new TimeOnly(15, 0, 0), new TimeOnly(7, 0, 0), 17 },
                    { 10, new TimeOnly(16, 0, 0), new TimeOnly(8, 0, 0), 19 }
                });

            migrationBuilder.InsertData(
                table: "patients",
                columns: new[] { "id", "telephone", "user_id" },
                values: new object[,]
                {
                    { 1, "3001234567", 2 },
                    { 2, "3002345678", 4 },
                    { 3, "3003456789", 6 },
                    { 4, "3004567890", 8 },
                    { 5, "3005678901", 10 },
                    { 6, "3006789012", 12 },
                    { 7, "3007890123", 14 },
                    { 8, "3008901234", 16 },
                    { 9, "3009012345", 18 },
                    { 10, "3000123456", 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 20);
        }
    }
}
