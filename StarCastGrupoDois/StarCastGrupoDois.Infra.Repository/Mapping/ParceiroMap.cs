using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarCastGrupoDois.Domain.Entities.Models;

namespace StarCastGrupoDois.Infra.Repository.Mapping
{

    internal class ParceiroMap : IEntityTypeConfiguration<Parceiro>
    {
        public void Configure(EntityTypeBuilder<Parceiro> builder)
        {
            builder.ToTable("parceiro", "dbo");

            builder.HasKey(f => f.Codigo);

            builder.Property(f => f.Codigo)
                .HasColumnName("cd_parceiro");

            builder.Property(c => c.Nome)
                .HasColumnName("nm_parceiro")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Desconto)
                .HasColumnName("dc_Desconto")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();


            // Map Value Object
            builder.OwnsOne(s => s.Cnpj, cb =>
            {
                cb.Property(c => c.Numero)
                    .HasColumnName("nm_cnpj")
                    .HasColumnType("varchar(14)")
                    .IsRequired();
            });
        }
    }
}

