using Everis.Domain.Entities;
using Everis.Infra.Map;
using Microsoft.EntityFrameworkCore;

namespace Everis.Infra
{
    public class EverisContext : DbContext
    {
        public EverisContext(){}

        public EverisContext(DbContextOptions<EverisContext> options) : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ForSqlServerUseIdentityColumns();
            modelBuilder.HasDefaultSchema("EverisPedidos");

            MapPedido.MapingPedido(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Criar classe factory para resolver essa conexão fixa
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DBPedidos;Trusted_Connection=True;MultipleActiveResultSets=true");

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Pedido> Pedidos { get; set; }

    }
}
