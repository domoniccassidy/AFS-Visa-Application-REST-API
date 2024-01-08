using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AFS_Visa_Application_REST_API.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalInformation",
                columns: table => new
                {
                    AdditionalInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InformationTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformationDataType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalInformation", x => x.AdditionalInformationId);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalInformationVisa",
                columns: table => new
                {
                    AdditionalInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalInformationVisa", x => new { x.AdditionalInformationId, x.VisaId });
                    table.ForeignKey(
                        name: "FK_AdditionalInformationVisa_AdditionalInformation_AdditionalInformationId",
                        column: x => x.AdditionalInformationId,
                        principalTable: "AdditionalInformation",
                        principalColumn: "AdditionalInformationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdditionalInformationVisa_Visa_VisaId",
                        column: x => x.VisaId,
                        principalTable: "Visa",
                        principalColumn: "VisaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalInformationVisa_VisaId",
                table: "AdditionalInformationVisa",
                column: "VisaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalInformationVisa");

            migrationBuilder.DropTable(
                name: "AdditionalInformation");
        }
    }
}
