using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Estrutura.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(50)", nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraUltimaAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "TEXT", nullable: false),
                    LojaId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ClienteFornecedorId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TransportadoraId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CaixaMovimentacaoId = table.Column<Guid>(type: "TEXT", nullable: true),
                    VendedorId = table.Column<Guid>(type: "TEXT", nullable: true),
                    TabelaPrecoId = table.Column<Guid>(type: "TEXT", nullable: true),
                    LocalEstoqueId = table.Column<Guid>(type: "TEXT", nullable: false),
                    FaturaId = table.Column<Guid>(type: "TEXT", nullable: true),
                    NumeroOperacao = table.Column<long>(type: "INTEGER", nullable: false, defaultValue: 0L),
                    Status = table.Column<int>(type: "INTEGER", nullable: false, defaultValue: 1),
                    TipoOperacao = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCompetencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CnpjCpf = table.Column<string>(type: "varchar(18)", nullable: true),
                    Observacao = table.Column<string>(type: "varchar(500)", nullable: true),
                    Historico = table.Column<string>(type: "varchar(500)", nullable: true),
                    MotivoCancelamento = table.Column<string>(type: "varchar(255)", nullable: true),
                    NumeroDocumento = table.Column<string>(type: "varchar(20)", nullable: true),
                    ValorTotal = table.Column<decimal>(type: "decimal(14,4)", nullable: false, defaultValue: 0m),
                    ValorTotalDescontoItem = table.Column<decimal>(type: "decimal(14,4)", nullable: false, defaultValue: 0m),
                    ValorTotalDescontoAdicional = table.Column<decimal>(type: "decimal(14,4)", nullable: false, defaultValue: 0m),
                    ValorDescontoAdicional = table.Column<decimal>(type: "decimal(14,4)", nullable: false, defaultValue: 0m),
                    TipoDescontoAdicional = table.Column<int>(type: "INTEGER", nullable: false),
                    ValorTotalAcrescimo = table.Column<decimal>(type: "decimal(14,4)", nullable: false, defaultValue: 0m),
                    ValorTotalOutrasDespesas = table.Column<decimal>(type: "decimal(14,4)", nullable: false, defaultValue: 0m),
                    ValorTotalFrete = table.Column<decimal>(type: "decimal(14,4)", nullable: false, defaultValue: 0m),
                    ValorTotalItensSemDesconto = table.Column<decimal>(type: "decimal(14,4)", nullable: false, defaultValue: 0m),
                    ValorTotalItensComDesconto = table.Column<decimal>(type: "decimal(14,4)", nullable: false, defaultValue: 0m),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraUltimaAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tamanho",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(50)", nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataHoraUltimaAlteracao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tamanho", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cor_Descricao",
                table: "Cor",
                column: "Descricao",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Operacao_LojaId_NumeroOperacao",
                table: "Operacao",
                columns: new[] { "LojaId", "NumeroOperacao" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tamanho_Descricao",
                table: "Tamanho",
                column: "Descricao",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cor");

            migrationBuilder.DropTable(
                name: "Operacao");

            migrationBuilder.DropTable(
                name: "Tamanho");
        }
    }
}
