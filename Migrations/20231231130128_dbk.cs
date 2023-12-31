using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalRandevu.Migrations
{
    /// <inheritdoc />
    public partial class dbk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_User_DoctorID",
                table: "Users",
                newName: "IX_Users_DoctorID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_PatientID",
                table: "Reservations",
                column: "PatientID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Doctors_DoctorID",
                table: "Users",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_PatientID",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Doctors_DoctorID",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameIndex(
                name: "IX_Users_DoctorID",
                table: "User",
                newName: "IX_User_DoctorID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_User_PatientID",
                table: "Reservations",
                column: "PatientID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Doctors_DoctorID",
                table: "User",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID");
        }
    }
}
