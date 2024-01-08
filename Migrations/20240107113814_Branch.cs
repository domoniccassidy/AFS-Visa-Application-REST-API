using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AFS_Visa_Application_REST_API.Migrations
{
    /// <inheritdoc />
    public partial class Branch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BranchId",
                table: "VisaApplication",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchCode = table.Column<int>(type: "int", nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.BranchId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VisaApplication_BranchId",
                table: "VisaApplication",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_VisaApplication_Branch_BranchId",
                table: "VisaApplication",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisaApplication_Branch_BranchId",
                table: "VisaApplication");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropIndex(
                name: "IX_VisaApplication_BranchId",
                table: "VisaApplication");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "VisaApplication");
        }
    }
}
