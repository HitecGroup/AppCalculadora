using AppCalculadora.Repositories;
using AppCalculadora.Shared;
using Microsoft.AspNetCore.Mvc;

namespace AppCalculadora.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoricosController : ControllerBase
    {
        private readonly IHistoricoRepository _historicoRepository;

        public HistoricosController(IHistoricoRepository historicoRepository)
        {			
			_historicoRepository = historicoRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Historico historico)
        {
            if (historico == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            await _historicoRepository.InsertHistorico (historico);
            return NoContent();
        }

        [HttpGet]
        public async Task<IEnumerable<Historico>> Get()
        { 
            return await _historicoRepository.GetAllHistoricos();
        }

        [HttpGet("{user}")]
        public async Task<IEnumerable<Historico>> Get(string user)
        {
            return await _historicoRepository.GetHistoricosByUser(user);
        }
    }
}
