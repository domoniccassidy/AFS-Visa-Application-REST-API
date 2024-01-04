using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AFS_Visa_Application_REST_API.Migrations
{
    /// <inheritdoc />
    public partial class DocumentationRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocumentationRequired",
                columns: table => new
                {
                    DocumentationRequiredId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentationTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentationRequired", x => x.DocumentationRequiredId);
                });

            migrationBuilder.CreateTable(
                name: "DocumentationRequiredVisa",
                columns: table => new
                {
                    DocumentationRequiredId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentationRequiredVisa", x => new { x.DocumentationRequiredId, x.VisaId });
                    table.ForeignKey(
                        name: "FK_DocumentationRequiredVisa_DocumentationRequired_DocumentationRequiredId",
                        column: x => x.DocumentationRequiredId,
                        principalTable: "DocumentationRequired",
                        principalColumn: "DocumentationRequiredId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentationRequiredVisa_Visa_VisaId",
                        column: x => x.VisaId,
                        principalTable: "Visa",
                        principalColumn: "VisaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DocumentationRequiredVisa_VisaId",
                table: "DocumentationRequiredVisa",
                column: "VisaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentationRequiredVisa");

            migrationBuilder.DropTable(
                name: "DocumentationRequired");
        }
    }
}
