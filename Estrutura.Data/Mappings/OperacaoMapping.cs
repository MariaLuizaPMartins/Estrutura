using Estrutura.Data.Models;
using Estrutura.Shared.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estrutura.Data.Mappings
{
    public class OperacaoMapping : IEntityTypeConfiguration<Operacao>
    {
        public void Configure(EntityTypeBuilder<Operacao> builder)
        {
            // Primary Key
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            // Property
            builder.Property(p => p.DataHoraCadastro).HasColumnType("datetime2");
            builder.Property(p => p.DataHoraUltimaAlteracao).HasColumnType("datetime2");
            builder.Property(p => p.DataCompetencia).HasColumnType("datetime2");

            builder.Property(p => p.NumeroOperacao).HasDefaultValue(0);
            builder.Property(p => p.Status).HasDefaultValue(StatusOperacao.EFETUADA);
            builder.Property(p => p.MotivoCancelamento).HasColumnType("varchar(255)");
            builder.Property(p => p.ValorTotal).HasColumnType("decimal(14,4)").HasDefaultValue(0.00);
            builder.Property(p => p.ValorTotalDescontoItem).HasColumnType("decimal(14,4)").HasDefaultValue(0.00);
            builder.Property(p => p.ValorTotalDescontoAdicional).HasColumnType("decimal(14,4)").HasDefaultValue(0.00);
            builder.Property(p => p.ValorDescontoAdicional).HasColumnType("decimal(14,4)").HasDefaultValue(0.00);
            builder.Property(p => p.ValorTotalAcrescimo).HasColumnType("decimal(14,4)").HasDefaultValue(0.00);
            builder.Property(p => p.ValorTotalOutrasDespesas).HasColumnType("decimal(14,4)").HasDefaultValue(0.00);
            builder.Property(p => p.ValorTotalFrete).HasColumnType("decimal(14,4)").HasDefaultValue(0.00);
            builder.Property(p => p.ValorTotalItensComDesconto).HasColumnType("decimal(14,4)").HasDefaultValue(0.00);
            builder.Property(p => p.ValorTotalItensSemDesconto).HasColumnType("decimal(14,4)").HasDefaultValue(0.00);
            builder.Property(p => p.CnpjCpf).HasColumnType("varchar(18)");
            builder.Property(p => p.Observacao).HasColumnType("varchar(500)");
            builder.Property(p => p.Historico).HasColumnType("varchar(500)");
            builder.Property(p => p.NumeroDocumento).HasColumnType("varchar(20)");

            // Index
            builder.HasIndex(e => new { e.LojaId, e.NumeroOperacao }).IsUnique();
        }
    }
}
