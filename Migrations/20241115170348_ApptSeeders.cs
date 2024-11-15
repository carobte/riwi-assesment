using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assessment_CarolinaBustamante.Migrations
{
    /// <inheritdoc />
    public partial class ApptSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "id", "date", "doctor_id", "notes", "patient_id", "reason", "status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 20, 9, 30, 0, 0, DateTimeKind.Unspecified), 2, "First-time patient, check medical history.", 1, "General consultation", "scheduled" },
                    { 2, new DateTime(2024, 11, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, "Patient has a history of hypertension.", 2, "Blood pressure check", "scheduled" },
                    { 3, new DateTime(2024, 11, 22, 11, 15, 0, 0, DateTimeKind.Unspecified), 1, "Possible gastritis, prescribed medication.", 3, "Abdominal pain", "completed" },
                    { 4, new DateTime(2024, 11, 23, 14, 45, 0, 0, DateTimeKind.Unspecified), 4, "", 4, "Annual check-up", "scheduled" },
                    { 5, new DateTime(2024, 11, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 5, "Patient canceled due to personal reasons.", 5, "Dermatology consultation", "cancelled" },
                    { 6, new DateTime(2024, 11, 25, 13, 30, 0, 0, DateTimeKind.Unspecified), 2, "Review lab results and discuss next steps.", 6, "Follow-up on blood tests", "scheduled" },
                    { 7, new DateTime(2024, 11, 26, 9, 0, 0, 0, DateTimeKind.Unspecified), 3, "Prescribed antiviral medication.", 7, "Flu symptoms", "completed" },
                    { 8, new DateTime(2024, 11, 27, 10, 45, 0, 0, DateTimeKind.Unspecified), 4, "Patient is a child, bring vaccination record.", 8, "Pediatric consultation", "scheduled" },
                    { 9, new DateTime(2024, 11, 28, 15, 30, 0, 0, DateTimeKind.Unspecified), 1, "Patient requested to change the date.", 9, "Diabetes management", "rescheduled" },
                    { 10, new DateTime(2024, 11, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 5, "Focus on lower back pain.", 10, "Physical therapy", "scheduled" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 10);
        }
    }
}
