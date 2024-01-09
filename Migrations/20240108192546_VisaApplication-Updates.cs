using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AFS_Visa_Application_REST_API.Migrations
{
    /// <inheritdoc />
    public partial class VisaApplicationUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgentAssignedToId",
                table: "VisaApplication");

            migrationBuilder.DropColumn(
                name: "ApplicantId",
                table: "VisaApplication");

            migrationBuilder.AddColumn<DateTime>(
                name: "ArrivalDate",
                table: "VisaApplication",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DepartureDate",
                table: "VisaApplication",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "VisaApplication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "VisaApplication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArrivalDate",
                table: "VisaApplication");

            migrationBuilder.DropColumn(
                name: "DepartureDate",
                table: "VisaApplication");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "VisaApplication");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "VisaApplication");

            migrationBuilder.AddColumn<Guid>(
                name: "AgentAssignedToId",
                table: "VisaApplication",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicantId",
                table: "VisaApplication",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
