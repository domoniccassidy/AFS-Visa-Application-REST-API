using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AFS_Visa_Application_REST_API.Migrations
{
    /// <inheritdoc />
    public partial class AddVisaApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Visa",
                columns: table => new
                {
                    VisaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisaType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppointmentRequired = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visa", x => x.VisaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VisaApplication_VisaId",
                table: "VisaApplication",
                column: "VisaId");

            migrationBuilder.AddForeignKey(
                name: "FK_VisaApplication_Visa_VisaId",
                table: "VisaApplication",
                column: "VisaId",
                principalTable: "Visa",
                principalColumn: "VisaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisaApplication_Visa_VisaId",
                table: "VisaApplication");

            migrationBuilder.DropTable(
                name: "Visa");

            migrationBuilder.DropIndex(
                name: "IX_VisaApplication_VisaId",
                table: "VisaApplication");
        }
    }
}
