using AppCalculadora.Repositories;
using AppCalculadora.Shared;
using Microsoft.AspNetCore.Mvc;

namespace AppCalculadora.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculosController : ControllerBase
    {
        private readonly ICalculoRepository _calculoRepository;

        public CalculosController(ICalculoRepository calculoRepository)
        {
            _calculoRepository = calculoRepository;
        }

        [HttpGet("{idModelo}/{vIncoterm}/{idDestino}/{vCosto}")]
		public async Task<Calculo> Get(int idModelo, int vIncoterm, int idDestino, double vCosto)
		{
			return await _calculoRepository.GetCalculo (idModelo, vIncoterm, idDestino, vCosto);
		}
	}
}

