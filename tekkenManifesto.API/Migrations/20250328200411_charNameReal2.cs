using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tekkenManifesto.API.Migrations
{
    /// <inheritdoc />
    public partial class charNameReal2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Combos_CharID",
                table: "Combos");

            migrationBuilder.AddColumn<string>(
                name: "CharName",
                table: "Combos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Chars",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Combos_CharID_CharName",
                table: "Combos",
                columns: new[] { "CharID", "CharName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chars_Name",
                table: "Chars",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Combos_CharID_CharName",
                table: "Combos");

            migrationBuilder.DropIndex(
                name: "IX_Chars_Name",
                table: "Chars");

            migrationBuilder.DropColumn(
                name: "CharName",
                table: "Combos");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Chars",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_Combos_CharID",
                table: "Combos",
                column: "CharID",
                unique: true);
        }
    }
}
