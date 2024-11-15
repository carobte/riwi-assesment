using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assessment_CarolinaBustamante.Migrations
{
    /// <inheritdoc />
    public partial class FixTablesName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointment_doctor_doctor_id",
                table: "appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_appointment_patient_patient_id",
                table: "appointment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_patient",
                table: "patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_doctor",
                table: "doctor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_appointment",
                table: "appointment");

            migrationBuilder.RenameTable(
                name: "patient",
                newName: "patients");

            migrationBuilder.RenameTable(
                name: "doctor",
                newName: "doctors");

            migrationBuilder.RenameTable(
                name: "appointment",
                newName: "appointments");

            migrationBuilder.RenameIndex(
                name: "IX_patient_email",
                table: "patients",
                newName: "IX_patients_email");

            migrationBuilder.RenameIndex(
                name: "IX_doctor_email",
                table: "doctors",
                newName: "IX_doctors_email");

            migrationBuilder.RenameIndex(
                name: "IX_appointment_patient_id",
                table: "appointments",
                newName: "IX_appointments_patient_id");

            migrationBuilder.RenameIndex(
                name: "IX_appointment_doctor_id",
                table: "appointments",
                newName: "IX_appointments_doctor_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_patients",
                table: "patients",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_doctors",
                table: "doctors",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_appointments",
                table: "appointments",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_doctors_doctor_id",
                table: "appointments",
                column: "doctor_id",
                principalTable: "doctors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_patients_patient_id",
                table: "appointments",
                column: "patient_id",
                principalTable: "patients",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_doctors_doctor_id",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_appointments_patients_patient_id",
                table: "appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_patients",
                table: "patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_doctors",
                table: "doctors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_appointments",
                table: "appointments");

            migrationBuilder.RenameTable(
                name: "patients",
                newName: "patient");

            migrationBuilder.RenameTable(
                name: "doctors",
                newName: "doctor");

            migrationBuilder.RenameTable(
                name: "appointments",
                newName: "appointment");

            migrationBuilder.RenameIndex(
                name: "IX_patients_email",
                table: "patient",
                newName: "IX_patient_email");

            migrationBuilder.RenameIndex(
                name: "IX_doctors_email",
                table: "doctor",
                newName: "IX_doctor_email");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_patient_id",
                table: "appointment",
                newName: "IX_appointment_patient_id");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_doctor_id",
                table: "appointment",
                newName: "IX_appointment_doctor_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_patient",
                table: "patient",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_doctor",
                table: "doctor",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_appointment",
                table: "appointment",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_appointment_doctor_doctor_id",
                table: "appointment",
                column: "doctor_id",
                principalTable: "doctor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointment_patient_patient_id",
                table: "appointment",
                column: "patient_id",
                principalTable: "patient",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
