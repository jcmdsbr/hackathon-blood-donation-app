using Microsoft.EntityFrameworkCore;
using StarCastGrupoDois.Domain.Entities.Models;
using StarCastGrupoDois.Infra.Repository.Mapping;

namespace StarCastGrupoDois.Infra.Repository.Context
{
    public class StarCastGroupoDoisContexto : DbContext
    {
        public StarCastGroupoDoisContexto(DbContextOptions<StarCastGroupoDoisContexto> options) : base(options)
        {
        }

        public DbSet<Doador> Doadores { get; set; }
        public DbSet<Doacao> Doacoes { get; set; }
        public DbSet<Parceiro> Parceiros { get; set; }
        public DbSet<Alerta> Alertas { get; set; }
        public DbSet<AlertaDoador> AlertasDoadores { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DoadorMap());
            modelBuilder.ApplyConfiguration(new DoacaoMap());
            modelBuilder.ApplyConfiguration(new ParceiroMap());
            modelBuilder.ApplyConfiguration(new AlertaMap());
            modelBuilder.ApplyConfiguration(new AlertaDoadorMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}