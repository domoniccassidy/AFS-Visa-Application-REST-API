using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AFS_Visa_Application_REST_API.Migrations
{
    /// <inheritdoc />
    public partial class Country : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "Visa",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "CountryExemption",
                columns: table => new
                {
                    CountriesExemptCountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisasExemptVisaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryExemption", x => new { x.CountriesExemptCountryId, x.VisasExemptVisaId });
                    table.ForeignKey(
                        name: "FK_CountryExemption_Country_CountriesExemptCountryId",
                        column: x => x.CountriesExemptCountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryExemption_Visa_VisasExemptVisaId",
                        column: x => x.VisasExemptVisaId,
                        principalTable: "Visa",
                        principalColumn: "VisaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Visa_CountryId",
                table: "Visa",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryExemption_VisasExemptVisaId",
                table: "CountryExemption",
                column: "VisasExemptVisaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visa_Country_CountryId",
                table: "Visa",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visa_Country_CountryId",
                table: "Visa");

            migrationBuilder.DropTable(
                name: "CountryExemption");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Visa_CountryId",
                table: "Visa");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Visa");
        }
    }
}
