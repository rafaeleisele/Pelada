using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pelada.Migrations
{
    /// <inheritdoc />
    public partial class corrigindocolunas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_jogadores_jogadores_JogadorId",
                table: "jogadores");

            migrationBuilder.DropForeignKey(
                name: "FK_times_times_TimeId",
                table: "times");

            migrationBuilder.DropIndex(
                name: "IX_times_TimeId",
                table: "times");

            migrationBuilder.DropIndex(
                name: "IX_jogadores_JogadorId",
                table: "jogadores");

            migrationBuilder.DropColumn(
                name: "TimeId",
                table: "times");

            migrationBuilder.DropColumn(
                name: "JogadorId",
                table: "jogadores");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TimeId",
                table: "times",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JogadorId",
                table: "jogadores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_times_TimeId",
                table: "times",
                column: "TimeId");

            migrationBuilder.CreateIndex(
                name: "IX_jogadores_JogadorId",
                table: "jogadores",
                column: "JogadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_jogadores_jogadores_JogadorId",
                table: "jogadores",
                column: "JogadorId",
                principalTable: "jogadores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_times_times_TimeId",
                table: "times",
                column: "TimeId",
                principalTable: "times",
                principalColumn: "Id");
        }
    }
}
