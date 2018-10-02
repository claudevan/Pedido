using System;

namespace Everis.Domain.Entities
{
    public class Pedido
    {
        public Pedido()
        {
        }

        public Pedido(string nomeCliente, string email, string cPF, decimal valorTotal, DateTime dataPedido)
        {
            NomeCliente = nomeCliente;
            Email = email;
            CPF = cPF;
            ValorTotal = valorTotal;
            DataPedido = dataPedido;
        }

        public void Alterar(string nomeCliente, string email, string cPF, decimal valorTotal, DateTime dataPedido)
        {
            NomeCliente = nomeCliente;
            Email = email;
            CPF = cPF;
            ValorTotal = valorTotal;
            DataPedido = dataPedido;
        }

        
        public int Id { get; private set; }
        public string NomeCliente { get; private set; }
        public string Email { get; private set; }
        public string CPF { get; private set; }
        public decimal ValorTotal { get; private set; }
        public DateTime DataPedido { get; private set; }

    }
}
