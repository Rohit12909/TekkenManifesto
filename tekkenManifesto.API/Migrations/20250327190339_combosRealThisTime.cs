using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tekkenManifesto.API.Migrations
{
    /// <inheritdoc />
    public partial class combosRealThisTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeatEngager_Combos_ComboId",
                table: "HeatEngager");

            migrationBuilder.DropForeignKey(
                name: "FK_Launcher_Combos_ComboId",
                table: "Launcher");

            migrationBuilder.DropForeignKey(
                name: "FK_Punisher_Combos_ComboId",
                table: "Punisher");

            migrationBuilder.DropForeignKey(
                name: "FK_Stance_Combos_ComboId",
                table: "Stance");

            migrationBuilder.RenameColumn(
                name: "ComboId",
                table: "Stance",
                newName: "CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Stance_ComboId",
                table: "Stance",
                newName: "IX_Stance_CharacterId");

            migrationBuilder.RenameColumn(
                name: "ComboId",
                table: "Punisher",
                newName: "CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Punisher_ComboId",
                table: "Punisher",
                newName: "IX_Punisher_CharacterId");

            migrationBuilder.RenameColumn(
                name: "ComboId",
                table: "Launcher",
                newName: "CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Launcher_ComboId",
                table: "Launcher",
                newName: "IX_Launcher_CharacterId");

            migrationBuilder.RenameColumn(
                name: "ComboId",
                table: "HeatEngager",
                newName: "CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_HeatEngager_ComboId",
                table: "HeatEngager",
                newName: "IX_HeatEngager_CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_HeatEngager_Chars_CharacterId",
                table: "HeatEngager",
                column: "CharacterId",
                principalTable: "Chars",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Launcher_Chars_CharacterId",
                table: "Launcher",
                column: "CharacterId",
                principalTable: "Chars",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Punisher_Chars_CharacterId",
                table: "Punisher",
                column: "CharacterId",
                principalTable: "Chars",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stance_Chars_CharacterId",
                table: "Stance",
                column: "CharacterId",
                principalTable: "Chars",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeatEngager_Chars_CharacterId",
                table: "HeatEngager");

            migrationBuilder.DropForeignKey(
                name: "FK_Launcher_Chars_CharacterId",
                table: "Launcher");

            migrationBuilder.DropForeignKey(
                name: "FK_Punisher_Chars_CharacterId",
                table: "Punisher");

            migrationBuilder.DropForeignKey(
                name: "FK_Stance_Chars_CharacterId",
                table: "Stance");

            migrationBuilder.RenameColumn(
                name: "CharacterId",
                table: "Stance",
                newName: "ComboId");

            migrationBuilder.RenameIndex(
                name: "IX_Stance_CharacterId",
                table: "Stance",
                newName: "IX_Stance_ComboId");

            migrationBuilder.RenameColumn(
                name: "CharacterId",
                table: "Punisher",
                newName: "ComboId");

            migrationBuilder.RenameIndex(
                name: "IX_Punisher_CharacterId",
                table: "Punisher",
                newName: "IX_Punisher_ComboId");

            migrationBuilder.RenameColumn(
                name: "CharacterId",
                table: "Launcher",
                newName: "ComboId");

            migrationBuilder.RenameIndex(
                name: "IX_Launcher_CharacterId",
                table: "Launcher",
                newName: "IX_Launcher_ComboId");

            migrationBuilder.RenameColumn(
                name: "CharacterId",
                table: "HeatEngager",
                newName: "ComboId");

            migrationBuilder.RenameIndex(
                name: "IX_HeatEngager_CharacterId",
                table: "HeatEngager",
                newName: "IX_HeatEngager_ComboId");

            migrationBuilder.AddForeignKey(
                name: "FK_HeatEngager_Combos_ComboId",
                table: "HeatEngager",
                column: "ComboId",
                principalTable: "Combos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Launcher_Combos_ComboId",
                table: "Launcher",
                column: "ComboId",
                principalTable: "Combos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Punisher_Combos_ComboId",
                table: "Punisher",
                column: "ComboId",
                principalTable: "Combos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stance_Combos_ComboId",
                table: "Stance",
                column: "ComboId",
                principalTable: "Combos",
                principalColumn: "Id");
        }
    }
}
