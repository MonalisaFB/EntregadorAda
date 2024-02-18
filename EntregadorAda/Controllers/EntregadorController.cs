using Microsoft.AspNetCore.Mvc;
using Dados.Models;
using EntregadorAda.Request;
using Dados.Repositorio;



namespace EntregadorAda.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EntregadorController : ControllerBase
    {
        private readonly IEntregadorRepositorio _entregadorRepositorio;

        public EntregadorController(IEntregadorRepositorio entregadorRepositorio)
        {
            _entregadorRepositorio = entregadorRepositorio;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] string? cpf = null)
        {
            var entregador = _entregadorRepositorio.ConsultarCpf(cpf);
            return Ok(entregador);
        }

        [HttpPost]
        public IActionResult Post([FromBody] EntregadorRequest entregadorRequest)
        {
            var entregador = new EntregadorModel(entregadorRequest.Nome, entregadorRequest.CPF,
                entregadorRequest.Veiculo, entregadorRequest.Email, entregadorRequest.Nascimento, 
                entregadorRequest.Cidade, entregadorRequest.Estado);
            
            _entregadorRepositorio.CadastrarEntregador(entregador);
            return Ok(entregadorRequest);
        }

      


    }
}
