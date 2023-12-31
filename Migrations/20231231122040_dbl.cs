using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalRandevu.Migrations
{
    /// <inheritdoc />
    public partial class dbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PatientSername",
                table: "User",
                newName: "UserSurname");

            migrationBuilder.RenameColumn(
                name: "PatientName",
                table: "User",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "User",
                newName: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserSurname",
                table: "User",
                newName: "PatientSername");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "User",
                newName: "PatientName");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "User",
                newName: "PatientID");
        }
    }
}
