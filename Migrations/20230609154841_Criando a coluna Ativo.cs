using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pelada.Migrations
{
    /// <inheritdoc />
    public partial class CriandoacolunaAtivo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "jogadores",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "jogadores");
        }
    }
}
