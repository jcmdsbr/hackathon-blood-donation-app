using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarCastGrupoDois.Domain.Entities.Models;

namespace StarCastGrupoDois.Infra.Repository.Mapping
{
    internal class DoacaoMap : IEntityTypeConfiguration<Doacao>
    {
        public void Configure(EntityTypeBuilder<Doacao> builder)
        {
            builder.ToTable("doacao", "dbo");

            builder.HasKey(f => f.Codigo);

            builder.Property(f => f.Codigo)
                .HasColumnName("cd_doacao");

            builder.Property(c => c.TipoDoacao)
                .HasColumnName("cd_tipoDoacao")
                .IsRequired();


            builder.Property(c => c.Descricao)
              .HasColumnName("dc_doacao")
              .HasColumnType("varchar(100)")
              .HasMaxLength(100)
              .IsRequired();

            builder.HasMany(x => x.AlertasEmitidos)
                .WithOne(x => x.Doacao);

        }
    }
}
