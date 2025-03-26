using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tekkenManifesto.API.Migrations
{
    /// <inheritdoc />
    public partial class CharRankUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HighestRank",
                table: "Chars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Played",
                table: "Chars",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HighestRank",
                table: "Chars");

            migrationBuilder.DropColumn(
                name: "Played",
                table: "Chars");
        }
    }
}
