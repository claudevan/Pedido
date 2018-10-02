using Everis.Domain.Arguments;
using Everis.Domain.Entities;
using Everis.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace Everis.Infra.Repositories
{
    public class PedidoRepository : IServicePedido
    {

        //Deveria ter criado um reposityPattern pra não ficar repetindo código
        public Task<Pedido> Alterar(PedidoRequest pedidoRequest)
        {
            var db = new EverisContext();

            var pedido = db.Pedidos.Find(pedidoRequest.Id);

            pedido.Alterar(pedidoRequest.NomeCliente,
                    pedidoRequest.Email,
                    pedidoRequest.CPF,
                    pedidoRequest.ValorTotal,
                    pedidoRequest.DataPedido);

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
