using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AFS_Visa_Application_REST_API.Migrations
{
    /// <inheritdoc />
    public partial class BranchCountry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentDate",
                table: "VisaApplication");

            migrationBuilder.AddColumn<Guid>(
                name: "AppointmentId",
                table: "VisaApplication",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    AppointmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_Appointment_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VisaApplication_AppointmentId",
                table: "VisaApplication",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Branch_CountryId",
                table: "Branch",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_BranchId",
                table: "Appointment",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Branch_Country_CountryId",
                table: "Branch",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisaApplication_Appointment_AppointmentId",
                table: "VisaApplication",
                column: "AppointmentId",
                principalTable: "Appointment",
                principalColumn: "AppointmentId",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branch_Country_CountryId",
                table: "Branch");

            migrationBuilder.DropForeignKey(
                name: "FK_VisaApplication_Appointment_AppointmentId",
                table: "VisaApplication");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_VisaApplication_AppointmentId",
                table: "VisaApplication");

            migrationBuilder.DropIndex(
                name: "IX_Branch_CountryId",
                table: "Branch");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "VisaApplication");

            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentDate",
                table: "VisaApplication",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
