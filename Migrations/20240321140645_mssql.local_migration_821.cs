using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_821 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "produtos_categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cadastrado_Usuario = table.Column<int>(type: "int", nullable: true),
                    Cadastrado_Data = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Alterado_Usuario = table.Column<int>(type: "int", nullable: true),
                    Alterado_Data = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos_categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "unidades_medidas",
                columns: table => new
                {
                    Sigla = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Casas_Decimais = table.Column<short>(type: "smallint", nullable: true),
                    Ativa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cadastrado_Usuario = table.Column<int>(type: "int", nullable: true),
                    Cadastrado_Data = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Alterado_Usuario = table.Column<int>(type: "int", nullable: true),
                    Alterado_Data = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unidades_medidas", x => x.Sigla);
                });

            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco_Custo = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Preco_Venda = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Estoque_Minimo = table.Column<double>(type: "float", nullable: true),
                    Estoque_Maximo = table.Column<double>(type: "float", nullable: true),
                    Estoque_Saldo_Inicial = table.Column<double>(type: "float", nullable: true),
                    Estoque_Saldo_Inicial_Data = table.Column<DateOnly>(type: "date", nullable: true),
                    Ativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cadastrado_Usuario = table.Column<int>(type: "int", nullable: true),
                    Cadastrado_Data = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Alterado_Usuario = table.Column<int>(type: "int", nullable: true),
                    Alterado_Data = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Id_CategoriaId = table.Column<int>(type: "int", nullable: true),
                    UnSigla = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_produtos_produtos_categoria_Id_CategoriaId",
                        column: x => x.Id_CategoriaId,
                        principalTable: "produtos_categoria",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_produtos_unidades_medidas_UnSigla",
                        column: x => x.UnSigla,
                        principalTable: "unidades_medidas",
                        principalColumn: "Sigla");
                });

            migrationBuilder.CreateIndex(
                name: "IX_produtos_Id_CategoriaId",
                table: "produtos",
                column: "Id_CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_produtos_UnSigla",
                table: "produtos",
                column: "UnSigla");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produtos");

            migrationBuilder.DropTable(
                name: "produtos_categoria");

            migrationBuilder.DropTable(
                name: "unidades_medidas");
        }
    }
}
