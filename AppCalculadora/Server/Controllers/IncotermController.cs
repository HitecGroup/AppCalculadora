using AppCalculadora.Repositories;
using AppCalculadora.Shared;
using Microsoft.AspNetCore.Mvc;

namespace AppCalculadora.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncotermController : ControllerBase
    {
        private readonly IIncotermRepository _incotermRepository;
        

        public IncotermController(IIncotermRepository incotermRepository)
        {
			_incotermRepository = incotermRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Incoterm>> Get()
        { 
            return await _incotermRepository.GetAllIncoterm();
        }

    }
}
