using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AFS_Visa_Application_REST_API.Migrations
{
    /// <inheritdoc />
    public partial class VisaApplicationFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisaApplication_Appointment_AppointmentId",
                table: "VisaApplication");

            migrationBuilder.AlterColumn<Guid>(
                name: "AppointmentId",
                table: "VisaApplication",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_VisaApplication_Appointment_AppointmentId",
                table: "VisaApplication",
                column: "AppointmentId",
                principalTable: "Appointment",
                principalColumn: "AppointmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisaApplication_Appointment_AppointmentId",
                table: "VisaApplication");

            migrationBuilder.AlterColumn<Guid>(
                name: "AppointmentId",
                table: "VisaApplication",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_VisaApplication_Appointment_AppointmentId",
                table: "VisaApplication",
                column: "AppointmentId",
                principalTable: "Appointment",
                principalColumn: "AppointmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
