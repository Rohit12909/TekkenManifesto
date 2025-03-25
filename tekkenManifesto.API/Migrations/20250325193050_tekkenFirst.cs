using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tekkenManifesto.API.Migrations
{
    /// <inheritdoc />
    public partial class tekkenFirst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Combos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TextNotation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisualNotationURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Damage = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Combos_Chars_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Chars",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Combos_CharacterId",
                table: "Combos",
                column: "CharacterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Combos");

            migrationBuilder.DropTable(
                name: "Chars");
        }
    }
}
