using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tekkenManifesto.API.Migrations
{
    /// <inheritdoc />
    public partial class charIdToCombo2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Combos_Chars_characterId",
                table: "Combos");

            migrationBuilder.RenameColumn(
                name: "characterId",
                table: "Combos",
                newName: "CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Combos_characterId",
                table: "Combos",
                newName: "IX_Combos_CharacterId");

            migrationBuilder.AlterColumn<int>(
                name: "CharacterId",
                table: "Combos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "charsComboId",
                table: "Combos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Combos_Chars_CharacterId",
                table: "Combos",
                column: "CharacterId",
                principalTable: "Chars",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Combos_Chars_CharacterId",
                table: "Combos");

            migrationBuilder.DropColumn(
                name: "charsComboId",
                table: "Combos");

            migrationBuilder.RenameColumn(
                name: "CharacterId",
                table: "Combos",
                newName: "characterId");

            migrationBuilder.RenameIndex(
                name: "IX_Combos_CharacterId",
                table: "Combos",
                newName: "IX_Combos_characterId");

            migrationBuilder.AlterColumn<int>(
                name: "characterId",
                table: "Combos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Combos_Chars_characterId",
                table: "Combos",
                column: "characterId",
                principalTable: "Chars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
