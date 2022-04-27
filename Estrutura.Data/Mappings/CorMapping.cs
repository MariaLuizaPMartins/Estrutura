using Estrutura.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estrutura.Data.Mappings
{
    public class CorMapping : IEntityTypeConfiguration<Cor>
    {
        public void Configure(EntityTypeBuilder<Cor> builder)
        {
            // Primary Key
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            // Property
            builder.Property(p => p.DataHoraCadastro).HasColumnType("datetime2");
            builder.Property(p => p.DataHoraUltimaAlteracao).HasColumnType("datetime2");
            builder.Property(p => p.Descricao).HasColumnType("varchar(50)").IsRequired();

            // Index
            builder.HasIndex(e => new { e.Descricao }).IsUnique();
        }
    }
}
