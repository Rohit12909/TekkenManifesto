using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tekkenManifesto.API.Migrations
{
    /// <inheritdoc />
    public partial class combosReal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeatEngager",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Input = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FramesOB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComboId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeatEngager", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeatEngager_Combos_ComboId",
                        column: x => x.ComboId,
                        principalTable: "Combos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Launcher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Input = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FramesOB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComboId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Launcher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Launcher_Combos_ComboId",
                        column: x => x.ComboId,
                        principalTable: "Combos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Punisher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Input = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnemyIs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComboId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Punisher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Punisher_Combos_ComboId",
                        column: x => x.ComboId,
                        principalTable: "Combos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Stance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Input = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComboId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stance_Combos_ComboId",
                        column: x => x.ComboId,
                        principalTable: "Combos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeatEngager_ComboId",
                table: "HeatEngager",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_Launcher_ComboId",
                table: "Launcher",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_Punisher_ComboId",
                table: "Punisher",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_Stance_ComboId",
                table: "Stance",
                column: "ComboId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeatEngager");

            migrationBuilder.DropTable(
                name: "Launcher");

            migrationBuilder.DropTable(
                name: "Punisher");

            migrationBuilder.DropTable(
                name: "Stance");
        }
    }
}
