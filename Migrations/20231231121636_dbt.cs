using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalRandevu.Migrations
{
    /// <inheritdoc />
    public partial class dbt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Doctors_DoctorID",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Patients_PatientID",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patients",
                table: "Patients");

            migrationBuilder.RenameTable(
                name: "Patients",
                newName: "User");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_DoctorID",
                table: "User",
                newName: "IX_User_DoctorID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "PatientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_User_PatientID",
                table: "Reservations",
                column: "PatientID",
                principalTable: "User",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Doctors_DoctorID",
                table: "User",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_User_PatientID",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Doctors_DoctorID",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Patients");

            migrationBuilder.RenameIndex(
                name: "IX_User_DoctorID",
                table: "Patients",
                newName: "IX_Patients_DoctorID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patients",
                table: "Patients",
                column: "PatientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Doctors_DoctorID",
                table: "Patients",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Patients_PatientID",
                table: "Reservations",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
