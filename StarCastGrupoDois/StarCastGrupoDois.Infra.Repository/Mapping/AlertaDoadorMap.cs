using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarCastGrupoDois.Domain.Entities.Models;

namespace StarCastGrupoDois.Infra.Repository.Mapping
{
    class AlertaDoadorMap : IEntityTypeConfiguration<AlertaDoador>
    {
        public void Configure(EntityTypeBuilder<AlertaDoador> builder)
        {
            builder.ToTable("alertaDoador", "dbo");

            builder.HasKey(c => new { c.CodigoAlerta, AnimalId = c.CodigoDoador });


            builder.Property(f => f.CodigoAlerta)
                .HasColumnName("cd_alerta");


            builder.Property(f => f.CodigoDoador)
                .HasColumnName("cd_doador");


            builder.HasOne(s => s.Alerta)
                .WithMany()
                .HasForeignKey(e => e.CodigoAlerta)
                .IsRequired();

            builder.HasOne(s => s.Doador)
                .WithMany()
                .HasForeignKey(e => e.CodigoDoador)
                .IsRequired();
        }
    }
}
