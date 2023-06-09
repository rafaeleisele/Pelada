﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pelada.Migrations
{
    /// <inheritdoc />
    public partial class TimeIdparaIdTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdTime",
                table: "jogadores",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdTime",
                table: "jogadores");
        }
    }
}
