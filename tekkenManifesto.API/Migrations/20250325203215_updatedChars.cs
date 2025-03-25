using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tekkenManifesto.API.Migrations
{
    /// <inheritdoc />
    public partial class updatedChars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FightingStyle",
                table: "Chars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "History",
                table: "Chars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FightingStyle",
                table: "Chars");

            migrationBuilder.DropColumn(
                name: "History",
                table: "Chars");
        }
    }
}
