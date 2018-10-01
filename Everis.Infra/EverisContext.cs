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

        public DbSet<Pedido> Pedidos { get; set; }

    }
}
