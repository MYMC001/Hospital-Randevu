using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalRandevu.Migrations
{
    /// <inheritdoc />
    public partial class dbqw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Doctors_DoctorID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_DoctorID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DoctorID",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoctorID",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_DoctorID",
                table: "Users",
                column: "DoctorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Doctors_DoctorID",
                table: "Users",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID");
        }
    }
}
