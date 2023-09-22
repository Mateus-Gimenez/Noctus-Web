using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Noctus.Core.Migrations
{
    /// <inheritdoc />
    public partial class Alfabeto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alfabetos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Letra = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Codigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Celas = table.Column<int>(type: "int", nullable: false),
                    Inclusao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Alteracao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Excluido = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alfabetos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alfabetos");
        }
    }
}
