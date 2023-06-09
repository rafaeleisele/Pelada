using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pelada.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "times",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_times", x => x.Id);
                    table.ForeignKey(
                        name: "FK_times_times_TimeId",
                        column: x => x.TimeId,
                        principalTable: "times",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "jogadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nota = table.Column<double>(type: "float", nullable: false),
                    TimeId = table.Column<int>(type: "int", nullable: true),
                    IdTime = table.Column<int>(type: "int", nullable: true),
                    JogadorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jogadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_jogadores_jogadores_JogadorId",
                        column: x => x.JogadorId,
                        principalTable: "jogadores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_jogadores_times_TimeId",
                        column: x => x.TimeId,
                        principalTable: "times",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_jogadores_JogadorId",
                table: "jogadores",
                column: "JogadorId");

            migrationBuilder.CreateIndex(
                name: "IX_jogadores_TimeId",
                table: "jogadores",
                column: "TimeId");

            migrationBuilder.CreateIndex(
                name: "IX_times_TimeId",
                table: "times",
                column: "TimeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jogadores");

            migrationBuilder.DropTable(
                name: "times");
        }
    }
}
