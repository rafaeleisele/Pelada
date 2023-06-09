using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pelada.Migrations
{
    /// <inheritdoc />
    public partial class TentadoAlterar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdTime",
                table: "jogadores");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdTime",
                table: "jogadores",
                type: "int",
                nullable: true);
        }
    }
}
