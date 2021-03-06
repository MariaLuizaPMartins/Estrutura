// <auto-generated />
using System;
using Estrutura.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Estrutura.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220426191633_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("Estrutura.Data.Models.Cor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataHoraCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraUltimaAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Descricao")
                        .IsUnique();

                    b.ToTable("Cor");
                });

            modelBuilder.Entity("Estrutura.Data.Models.Operacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CaixaMovimentacaoId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClienteFornecedorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CnpjCpf")
                        .HasColumnType("varchar(18)");

                    b.Property<DateTime>("DataCompetencia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraUltimaAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("FaturaId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Historico")
                        .HasColumnType("varchar(500)");

                    b.Property<Guid>("LocalEstoqueId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("LojaId")
                        .HasColumnType("TEXT");

                    b.Property<string>("MotivoCancelamento")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("varchar(20)");

                    b.Property<long>("NumeroOperacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(0L);

                    b.Property<string>("Observacao")
                        .HasColumnType("varchar(500)");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(1);

                    b.Property<Guid?>("TabelaPrecoId")
                        .HasColumnType("TEXT");

                    b.Property<int>("TipoDescontoAdicional")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TipoOperacao")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("TransportadoraId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ValorDescontoAdicional")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(14,4)")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("ValorTotal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(14,4)")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("ValorTotalAcrescimo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(14,4)")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("ValorTotalDescontoAdicional")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(14,4)")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("ValorTotalDescontoItem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(14,4)")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("ValorTotalFrete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(14,4)")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("ValorTotalItensComDesconto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(14,4)")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("ValorTotalItensSemDesconto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(14,4)")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("ValorTotalOutrasDespesas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(14,4)")
                        .HasDefaultValue(0m);

                    b.Property<Guid?>("VendedorId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LojaId", "NumeroOperacao")
                        .IsUnique();

                    b.ToTable("Operacao");
                });

            modelBuilder.Entity("Estrutura.Data.Models.Tamanho", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataHoraCadastro")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataHoraUltimaAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Descricao")
                        .IsUnique();

                    b.ToTable("Tamanho");
                });
#pragma warning restore 612, 618
        }
    }
}
