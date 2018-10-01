using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace Everis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Inserir([FromBody] Domain.Entities.Pedido pedido)
        {
            try
            {

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

                return Ok(new { Messsage = "Inserido com sucesso" });
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> Alterar()
        {
            try
            {

                return Ok(new { Messsage = "Inserido com sucesso" });
            }
            catch (System.Exception)
            {

                throw;
            }
        }

    }
}