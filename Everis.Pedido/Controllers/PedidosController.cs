using Everis.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Everis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private IServicePedido _servicePedido;

        public PedidosController(IServicePedido servicePedido)
        {
            _servicePedido = servicePedido;
        }

        [HttpPost]
        public async Task<IActionResult> Inserir([FromBody] Domain.Entities.Pedido pedido)
        {
            try
            {
                if (pedido.Invalid)
                    return BadRequest(pedido.Notifications);

                var newPedido = _servicePedido.Inserir(pedido);

                return Ok(new { Messsage = "Inserido com sucesso" });
            }
            catch (System.Exception)
            {
                return BadRequest("Erro ao inserir dados, favor entrar em contato com o administrador do sistema");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Obter(int id)
        {
            try
            {
                var pedido = _servicePedido.Obter(id);
                return Ok(new { Data = pedido.Result });
            }
            catch (System.Exception)
            {
                return BadRequest("Erro ao obter dados, favor entrar em contato com o administrador do sistema");
            }
        }

        [HttpPut]
        public async Task<IActionResult> Alterar([FromBody] Domain.Entities.Pedido pedido)
        {
            try
            {
                if (pedido.Invalid)
                    return BadRequest(pedido.Notifications);

                var pedidoAlt = _servicePedido.Alterar(pedido);

                return Ok(new { Messsage = "Alterado com sucesso", Data = pedidoAlt });
            }
            catch (System.Exception)
            {
                return BadRequest("Erro ao alterar dados, favor entrar em contato com o administrador do sistema");
            }
        }

    }
}