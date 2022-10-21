using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppEdson.Data.Migrations
{
    public partial class _00000000000000_CreateIdentitySchemacs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caixa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<string>(maxLength: 10, nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Forma = table.Column<string>(maxLength: 10, nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caixa", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caixa");
        }
    }
}
