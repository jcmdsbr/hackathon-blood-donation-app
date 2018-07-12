using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarCastGrupoDois.Domain.Entities.Models;

namespace StarCastGrupoDois.Infra.Repository.Mapping
{
    public class DoadorMap : IEntityTypeConfiguration<Doador>
    {
        public void Configure(EntityTypeBuilder<Doador> builder)
        {
            builder.ToTable("doador", "dbo");

            builder.HasKey(f => f.Codigo);

            builder.Property(f => f.Codigo)
                .HasColumnName("cd_doador");

            builder.Property(c => c.Nome)
                .HasColumnName("nm_doador")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();


            builder.Property(c => c.Telefone)
                .HasColumnName("nm_telefone")
                .HasColumnType("varchar(11)")
                .HasMaxLength(11)
                .IsRequired();

            builder.HasMany(c => c.AlertasConfirmados)
                .WithOne(x => x.Doador);


            // Map Value Object
            builder.OwnsOne(s => s.Email, cb =>
            {
                cb.Property(c => c.Descricao)
                    .HasColumnName("email_doador")
                    .HasColumnType("varchar(14)")
                    .HasMaxLength(14)
                    .IsRequired();
            });


            builder.OwnsOne(s => s.Endereco, cb =>
            {
                cb.Property(c => c.Cidade)
                    .HasColumnName("endereco_cidade")
                    .HasColumnType("varchar(30)")
                    .HasMaxLength(30)
                    .IsRequired();
            });
        }
    }
}