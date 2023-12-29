using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HospitalRandevu.Migrations
{
    /// <inheritdoc />
    public partial class db8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Doctors_DoctorID",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Doctors_DoctorID",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Patient_PatientID",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient",
                table: "Patient");

            migrationBuilder.RenameTable(
                name: "Reservation",
                newName: "Reservations");

            migrationBuilder.RenameTable(
                name: "Patient",
                newName: "Patients");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_PatientID",
                table: "Reservations",
                newName: "IX_Reservations_PatientID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_DoctorID",
                table: "Reservations",
                newName: "IX_Reservations_DoctorID");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_DoctorID",
                table: "Patients",
                newName: "IX_Patients_DoctorID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations",
                column: "reservationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patients",
                table: "Patients",
                column: "PatientID");

            migrationBuilder.CreateTable(
                name: "DoctorWorkTimes",
                columns: table => new
                {
                    DoctorWorkTimeID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartHour = table.Column<TimeSpan>(type: "interval", nullable: false),
                    EndHour = table.Column<TimeSpan>(type: "interval", nullable: false),
                    WorkDaysFrom = table.Column<string>(type: "text", nullable: false),
                    WorkDaysTo = table.Column<string>(type: "text", nullable: false),
                    DoctorID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorWorkTimes", x => x.DoctorWorkTimeID);
                    table.ForeignKey(
                        name: "FK_DoctorWorkTimes_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorWorkTimes_DoctorID",
                table: "DoctorWorkTimes",
                column: "DoctorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Doctors_DoctorID",
                table: "Patients",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Doctors_DoctorID",
                table: "Reservations",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Patients_PatientID",
                table: "Reservations",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Doctors_DoctorID",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Doctors_DoctorID",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Patients_PatientID",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "DoctorWorkTimes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patients",
                table: "Patients");

            migrationBuilder.RenameTable(
                name: "Reservations",
                newName: "Reservation");

            migrationBuilder.RenameTable(
                name: "Patients",
                newName: "Patient");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_PatientID",
                table: "Reservation",
                newName: "IX_Reservation_PatientID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_DoctorID",
                table: "Reservation",
                newName: "IX_Reservation_DoctorID");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_DoctorID",
                table: "Patient",
                newName: "IX_Patient_DoctorID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation",
                column: "reservationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient",
                table: "Patient",
                column: "PatientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Doctors_DoctorID",
                table: "Patient",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Doctors_DoctorID",
                table: "Reservation",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Patient_PatientID",
                table: "Reservation",
                column: "PatientID",
                principalTable: "Patient",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
