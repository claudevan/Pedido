using Everis.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Everis.Infra.Map
{
    public static class MapPedido
    {
        public static void MapingPedido(ModelBuilder builder)
        {

            builder.Entity<Pedido>( c =>
            {
                
                c.ToTable("Pedidos");
                c.HasKey(p => p.Id).HasName("Id");
                c.Property(p => p.Id).ValueGeneratedOnAdd();
                c.Property(p => p.NomeCliente).IsRequired().HasMaxLength(100);
                c.Property(p => p.Email).IsRequired().HasMaxLength(60);
                c.Property(p => p.CPF).IsRequired().HasMaxLength(11);
                c.Property(p => p.DataPedido).IsRequired().HasColumnType("Date").HasDefaultValueSql("GetDate()");
                c.Property(p => p.ValorTotal).IsRequired().HasColumnType("decimal(18,2)");
            });
        }
    }
}



