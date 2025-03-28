using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tekkenManifesto.API.Migrations
{
    /// <inheritdoc />
    public partial class charIdToComboReal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "charsComboId",
                table: "Combos");

            migrationBuilder.AddColumn<string>(
                name: "charName",
                table: "Combos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "charName",
                table: "Combos");

            migrationBuilder.AddColumn<int>(
                name: "charsComboId",
                table: "Combos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
