using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CitelP.Migrations
{
    public partial class v100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Categoria = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Nome = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Fabricacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Validade = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Preco = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
