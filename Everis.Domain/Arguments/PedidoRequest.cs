using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace Everis.Domain.Arguments
{
    public class PedidoRequest : Notifiable, IValidatable
    {
        public PedidoRequest()
        {
            //AddNotifications(new Contract()
            //    .IsEmail(Email, "E-mail", "Não é um e-mail válido")
            //    .IsNullOrEmpty(Email, "E-Mail", "Campo não deve ser preenchido")
            //    .HasMaxLen(Email, 60, "E-Mail", "Tamanho maximo é de 60 caracteres")
            //    .IsGreaterThan(ValorTotal, 0, "Valor Total", "Valor do pedido deve ser maior que zero")
            //    .IsNullOrEmpty(NomeCliente, "Nome Cliente", "Campo não deve ser preenchido")
            //    .HasMaxLen(NomeCliente, 100, "Nome Cliente", "Tamanho maximo é de 100 caracteres")
            //    .IsNullOrEmpty(CPF, "CPF", "Campo não deve ser preenchido")
            //    .HasLen(CPF, 11, "CPF", "Campo deve conter 11 caracteres")
            //    .IsBetween(DataPedido, DateTime.Now.AddDays(-15), DateTime.Now.AddDays(15), "Data do Pedido", "Só são aceitos pedidos entre 15 dias antes/depois da data atual")
            //    );
        }

        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataPedido { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .IsEmail(Email, "E-mail", "Não é um e-mail válido")
                //.IsNullOrEmpty(Email, "E-Mail", "Campo deve ser preenchido")
                .HasMaxLen(Email, 60, "E-Mail", "Tamanho maximo é de 60 caracteres")
                .IsGreaterThan(ValorTotal, 0, "Valor Total", "Valor do pedido deve ser maior que zero")
                //.IsNullOrEmpty(NomeCliente, "Nome Cliente", "Campo deve ser preenchido")
                .HasMaxLen(NomeCliente, 100, "Nome Cliente", "Tamanho maximo é de 100 caracteres")
                //.IsNullOrEmpty(CPF, "CPF", "Campo deve ser preenchido")
                .HasLen(CPF, 11, "CPF", "Campo deve conter 11 caracteres")
                .IsBetween(DataPedido, DateTime.Now.AddDays(-15), DateTime.Now.AddDays(15), "Data do Pedido", "Só são aceitos pedidos entre 15 dias antes/depois da data atual")
                );

            //Aqui poderia colocar uma chamada de validação de CPF por Exemplo
        }
    }
}
