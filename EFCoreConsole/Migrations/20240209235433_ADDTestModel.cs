using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreConsole.Migrations
{
    /// <inheritdoc />
    public partial class ADDTestModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestModels",
                columns: table => new
                {
                    TestModelId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Numbers = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestModels", x => x.TestModelId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestModels");
        }
    }
}
