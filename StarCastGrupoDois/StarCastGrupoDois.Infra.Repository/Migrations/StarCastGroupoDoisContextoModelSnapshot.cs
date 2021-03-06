﻿// <auto-generated />

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarCastGrupoDois.Infra.Repository.Context;
using System;

namespace StarCastGrupoDois.Infra.Repository.Migrations
{
    [DbContext(typeof(StarCastGroupoDoisContexto))]
    internal class StarCastGroupoDoisContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StarCastGrupoDois.Domain.Entities.Models.Alerta", b =>
            {
                b.Property<Guid>("Codigo")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("cd_alerta");

                b.Property<Guid>("CodigoDoacao");

                b.Property<DateTime?>("DataConclusao")
                    .HasColumnName("dt_conclusao")
                    .HasColumnType("datetime");

                b.Property<DateTime>("DataEmissao")
                    .HasColumnName("dt_emissao")
                    .HasColumnType("datetime");

                b.Property<int>("TipoAlerta")
                    .HasColumnName("cd_tipo_alerta");

                b.HasKey("Codigo");

                b.HasIndex("CodigoDoacao");

                b.ToTable("alerta", "dbo");
            });

            modelBuilder.Entity("StarCastGrupoDois.Domain.Entities.Models.AlertaDoador", b =>
            {
                b.Property<Guid>("CodigoAlerta")
                    .HasColumnName("cd_alerta");

                b.Property<Guid>("CodigoDoador")
                    .HasColumnName("cd_doador");

                b.Property<Guid?>("AlertaCodigo1");

                b.Property<Guid?>("DoadorCodigo1");

                b.HasKey("CodigoAlerta", "CodigoDoador");

                b.HasIndex("AlertaCodigo1");

                b.HasIndex("CodigoDoador");

                b.HasIndex("DoadorCodigo1");

                b.ToTable("alertaDoador", "dbo");
            });

            modelBuilder.Entity("StarCastGrupoDois.Domain.Entities.Models.Doacao", b =>
            {
                b.Property<Guid>("Codigo")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("cd_doacao");

                b.Property<string>("Descricao")
                    .IsRequired()
                    .HasColumnName("dc_doacao")
                    .HasColumnType("varchar(100)")
                    .HasMaxLength(100);

                b.Property<int>("TipoDoacao")
                    .HasColumnName("cd_tipoDoacao");

                b.HasKey("Codigo");

                b.ToTable("doacao", "dbo");
            });

            modelBuilder.Entity("StarCastGrupoDois.Domain.Entities.Models.Doador", b =>
            {
                b.Property<Guid>("Codigo")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("cd_doador");

                b.Property<string>("Nome")
                    .IsRequired()
                    .HasColumnName("nm_doador")
                    .HasColumnType("varchar(50)")
                    .HasMaxLength(50);

                b.Property<string>("Telefone")
                    .IsRequired()
                    .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string),
                        new ConverterMappingHints(64)))
                    .HasColumnName("nm_telefone")
                    .HasColumnType("varchar(11)")
                    .HasMaxLength(11);

                b.HasKey("Codigo");

                b.ToTable("doador", "dbo");
            });

            modelBuilder.Entity("StarCastGrupoDois.Domain.Entities.Models.Parceiro", b =>
            {
                b.Property<Guid>("Codigo")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("cd_parceiro");

                b.Property<string>("Desconto")
                    .IsRequired()
                    .HasColumnName("dc_Desconto")
                    .HasColumnType("varchar(100)")
                    .HasMaxLength(100);

                b.Property<string>("Nome")
                    .IsRequired()
                    .HasColumnName("nm_parceiro")
                    .HasColumnType("varchar(50)")
                    .HasMaxLength(50);

                b.HasKey("Codigo");

                b.ToTable("parceiro", "dbo");
            });

            modelBuilder.Entity("StarCastGrupoDois.Domain.Entities.Models.Alerta", b =>
            {
                b.HasOne("StarCastGrupoDois.Domain.Entities.Models.Doacao", "Doacao")
                    .WithMany("AlertasEmitidos")
                    .HasForeignKey("CodigoDoacao")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("StarCastGrupoDois.Domain.Entities.Models.AlertaDoador", b =>
            {
                b.HasOne("StarCastGrupoDois.Domain.Entities.Models.Alerta")
                    .WithMany("DoadoresConfirmados")
                    .HasForeignKey("AlertaCodigo1");

                b.HasOne("StarCastGrupoDois.Domain.Entities.Models.Alerta", "Alerta")
                    .WithMany()
                    .HasForeignKey("CodigoAlerta")
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("StarCastGrupoDois.Domain.Entities.Models.Doador", "Doador")
                    .WithMany()
                    .HasForeignKey("CodigoDoador")
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("StarCastGrupoDois.Domain.Entities.Models.Doador")
                    .WithMany("AlertasConfirmados")
                    .HasForeignKey("DoadorCodigo1");
            });

            modelBuilder.Entity("StarCastGrupoDois.Domain.Entities.Models.Doador", b =>
            {
                b.OwnsOne("StarCastGrupoDois.Domain.Entities.ValueObject.Email", "Email", b1 =>
                {
                    b1.Property<Guid?>("DoadorCodigo");

                    b1.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("email_doador")
                        .HasColumnType("varchar(14)")
                        .HasMaxLength(14);

                    b1.ToTable("doador", "dbo");

                    b1.HasOne("StarCastGrupoDois.Domain.Entities.Models.Doador")
                        .WithOne("Email")
                        .HasForeignKey("StarCastGrupoDois.Domain.Entities.ValueObject.Email", "DoadorCodigo")
                        .OnDelete(DeleteBehavior.Cascade);
                });

                b.OwnsOne("StarCastGrupoDois.Domain.Entities.ValueObject.Endereco", "Endereco", b1 =>
                {
                    b1.Property<Guid?>("DoadorCodigo");

                    b1.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnName("endereco_cidade")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b1.ToTable("doador", "dbo");

                    b1.HasOne("StarCastGrupoDois.Domain.Entities.Models.Doador")
                        .WithOne("Endereco")
                        .HasForeignKey("StarCastGrupoDois.Domain.Entities.ValueObject.Endereco", "DoadorCodigo")
                        .OnDelete(DeleteBehavior.Cascade);
                });
            });

            modelBuilder.Entity("StarCastGrupoDois.Domain.Entities.Models.Parceiro", b =>
            {
                b.OwnsOne("StarCastGrupoDois.Domain.Entities.ValueObject.Cnpj", "Cnpj", b1 =>
                {
                    b1.Property<Guid?>("ParceiroCodigo");

                    b1.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnName("nm_cnpj")
                        .HasColumnType("varchar(14)");

                    b1.ToTable("parceiro", "dbo");

                    b1.HasOne("StarCastGrupoDois.Domain.Entities.Models.Parceiro")
                        .WithOne("Cnpj")
                        .HasForeignKey("StarCastGrupoDois.Domain.Entities.ValueObject.Cnpj", "ParceiroCodigo")
                        .OnDelete(DeleteBehavior.Cascade);
                });
            });
#pragma warning restore 612, 618
        }
    }
}