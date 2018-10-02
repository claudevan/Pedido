using Everis.Domain.Entities;
using Everis.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace Everis.Infra.Repositories
{
    public class PedidoRepository : IServicePedido
    {

        //Deveria ter criado um reposityPattern pra não ficar repetindo código
        public Task<Pedido> Alterar(Pedido pedido)
        {
            var db = new EverisContext();

            var pedidoAlt = db.Pedidos.Find(pedido.Id);

            pedidoAlt.NomeCliente = pedido.NomeCliente;

            db.SaveChanges();

            return Task.FromResult(pedido);
        }

        public Task<Pedido> Inserir(Pedido pedido)
        {
            var db = new EverisContext();

            db.Pedidos.Add(pedido);
            db.SaveChanges();

            return Task.FromResult(pedido);
        }

        public Task<Pedido> Obter(int id)
        {
            var db = new EverisContext();
            
            return Task.FromResult(db.Pedidos.Find(id));
        }
    }
}
