using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dados.Models;
using Dados;
using EntregadorAda.Filters;


namespace EntregadorAda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntregadorController : ControllerBase
    {
        private readonly IEntregadorRepositorio _entregadorRepositorio;
        public EntregadorController(IEntregadorRepositorio entregadorRepositorio)
        {
            _entregadorRepositorio = entregadorRepositorio;
        }

        [HttpPost]
        [ServiceFilter(typeof(AutorizacaoFiltro))]
        [ServiceFilter(typeof(ExcecaoFiltro))]

        public IActionResult From([FromBody] EntregadorModel entregador)
        {
            try
            {
                var novoEntregador
            }
        }

        
    }
}
