using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarCastGrupoDois.Domain.Entities.Models;

namespace StarCastGrupoDois.Infra.Repository.Mapping
{
    internal class AlertaMap : IEntityTypeConfiguration<Alerta>
    {
        public void Configure(EntityTypeBuilder<Alerta> builder)
        {
            builder.ToTable("alerta", "dbo");

            builder.HasKey(c => c.Codigo);

            builder.Property(c => c.Codigo)
                .HasColumnName("cd_alerta");

            builder.Property(c => c.TipoAlerta)
                .HasColumnName("cd_tipo_alerta")
                .IsRequired();


            builder.Property(c => c.DataConclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_conclusao");


            builder.Property(c => c.DataEmissao)
                .HasColumnType("datetime")
                .HasColumnName("dt_emissao");


            builder.HasOne(x => x.Doacao)
                .WithMany(x => x.AlertasEmitidos)
                .HasForeignKey(x => x.CodigoDoacao);


            builder.HasMany(c => c.DoadoresConfirmados)
                .WithOne(x => x.Alerta);
        }
    }
}