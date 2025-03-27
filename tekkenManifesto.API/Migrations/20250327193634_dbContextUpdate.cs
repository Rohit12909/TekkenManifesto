using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tekkenManifesto.API.Migrations
{
    /// <inheritdoc />
    public partial class dbContextUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stance",
                table: "Stance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Punisher",
                table: "Punisher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Launcher",
                table: "Launcher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HeatEngager",
                table: "HeatEngager");

            migrationBuilder.RenameTable(
                name: "Stance",
                newName: "Stances");

            migrationBuilder.RenameTable(
                name: "Punisher",
                newName: "Punishers");

            migrationBuilder.RenameTable(
                name: "Launcher",
                newName: "Launchers");

            migrationBuilder.RenameTable(
                name: "HeatEngager",
                newName: "HeatEngagers");

            migrationBuilder.RenameIndex(
                name: "IX_Stance_CharacterId",
                table: "Stances",
                newName: "IX_Stances_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Punisher_CharacterId",
                table: "Punishers",
                newName: "IX_Punishers_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Launcher_CharacterId",
                table: "Launchers",
                newName: "IX_Launchers_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_HeatEngager_CharacterId",
                table: "HeatEngagers",
                newName: "IX_HeatEngagers_CharacterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stances",
                table: "Stances",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Punishers",
                table: "Punishers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Launchers",
                table: "Launchers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeatEngagers",
                table: "HeatEngagers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HeatEngagers_Chars_CharacterId",
                table: "HeatEngagers",
                column: "CharacterId",
                principalTable: "Chars",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Launchers_Chars_CharacterId",
                table: "Launchers",
                column: "CharacterId",
                principalTable: "Chars",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Punishers_Chars_CharacterId",
                table: "Punishers",
                column: "CharacterId",
                principalTable: "Chars",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stances_Chars_CharacterId",
                table: "Stances",
                column: "CharacterId",
                principalTable: "Chars",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeatEngagers_Chars_CharacterId",
                table: "HeatEngagers");

            migrationBuilder.DropForeignKey(
                name: "FK_Launchers_Chars_CharacterId",
                table: "Launchers");

            migrationBuilder.DropForeignKey(
                name: "FK_Punishers_Chars_CharacterId",
                table: "Punishers");

            migrationBuilder.DropForeignKey(
                name: "FK_Stances_Chars_CharacterId",
                table: "Stances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stances",
                table: "Stances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Punishers",
                table: "Punishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Launchers",
                table: "Launchers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HeatEngagers",
                table: "HeatEngagers");

            migrationBuilder.RenameTable(
                name: "Stances",
                newName: "Stance");

            migrationBuilder.RenameTable(
                name: "Punishers",
                newName: "Punisher");

            migrationBuilder.RenameTable(
                name: "Launchers",
                newName: "Launcher");

            migrationBuilder.RenameTable(
                name: "HeatEngagers",
                newName: "HeatEngager");

            migrationBuilder.RenameIndex(
                name: "IX_Stances_CharacterId",
                table: "Stance",
                newName: "IX_Stance_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Punishers_CharacterId",
                table: "Punisher",
                newName: "IX_Punisher_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Launchers_CharacterId",
                table: "Launcher",
                newName: "IX_Launcher_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_HeatEngagers_CharacterId",
                table: "HeatEngager",
                newName: "IX_HeatEngager_CharacterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stance",
                table: "Stance",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Punisher",
                table: "Punisher",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Launcher",
                table: "Launcher",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeatEngager",
                table: "HeatEngager",
                column: "Id");

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
    }
}
