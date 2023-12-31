using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalRandevu.Migrations
{
    /// <inheritdoc />
    public partial class dbpo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Doctors_DoctorID",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_PatientID",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_DoctorID",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_PatientID",
                table: "Reservations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Reservations_DoctorID",
                table: "Reservations",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_PatientID",
                table: "Reservations",
                column: "PatientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Doctors_DoctorID",
                table: "Reservations",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_PatientID",
                table: "Reservations",
                column: "PatientID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
