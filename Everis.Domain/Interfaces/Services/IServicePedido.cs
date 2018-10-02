using Everis.Domain.Arguments;
using Everis.Domain.Entities;
using System.Threading.Tasks;

namespace Everis.Domain.Interfaces.Services
{
    public interface IServicePedido
    {
        Task<Pedido> Obter(int id);
        Task<Pedido> Inserir(Pedido pedido);
        Task<Pedido> Alterar(PedidoRequest pedido);

    }
}
