using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tekkenManifesto.API.Migrations
{
    /// <inheritdoc />
    public partial class charNameReal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Combos_CharName",
                table: "Combos");

            migrationBuilder.DropColumn(
                name: "CharName",
                table: "Combos");

            migrationBuilder.AddColumn<int>(
                name: "CharID",
                table: "Combos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Combos_CharID",
                table: "Combos",
                column: "CharID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Combos_CharID",
                table: "Combos");

            migrationBuilder.DropColumn(
                name: "CharID",
                table: "Combos");

            migrationBuilder.AddColumn<string>(
                name: "CharName",
                table: "Combos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Combos_CharName",
                table: "Combos",
                column: "CharName",
                unique: true);
        }
    }
}
