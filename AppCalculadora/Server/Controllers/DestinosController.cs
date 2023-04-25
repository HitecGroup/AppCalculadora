using AppCalculadora.Repositories;
using AppCalculadora.Shared;
using Microsoft.AspNetCore.Mvc;

namespace AppCalculadora.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinosController : ControllerBase
    {
        private readonly IDestinoRepository _destinoRepository;
        

        public DestinosController(IDestinoRepository destinoRepository)
        {
			_destinoRepository = destinoRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Destino destino)        
        {
            if (destino == null)
                return BadRequest();
            if (string.IsNullOrEmpty(destino.Ciudad))
                ModelState.AddModelError("Nombre", "Falta nombre de la ciudad");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _destinoRepository.InsertDestino(destino);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Destino destino)
        {
            if (destino == null)
                return BadRequest();
            if (string.IsNullOrEmpty(destino.idDestino.ToString()))
                ModelState.AddModelError("idPais", "Falta Id del destino");
			if (string.IsNullOrEmpty(destino.Ciudad))
				ModelState.AddModelError("Nombre", "Falta nombre del destino");

			if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _destinoRepository.UpdateDestino(destino);
            return NoContent();
        }

        [HttpGet]
        public async Task<IEnumerable<Destino>> Get()
        { 
            return await _destinoRepository.GetAllDestino();
        }

        [HttpGet("{id}")]
        public async Task<Destino> Get(int id)
        {
            return await _destinoRepository.GetDestinoById(id);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        { 
            await _destinoRepository.DeleteDestino(id);
        }
    }
}
