using AppCalculadora.Shared;

namespace AppCalculadora.Client.Services
{
    public interface IHistoricoService
    {
        Task<IEnumerable<Historico>> GetAllHistoricos();
		Task<IEnumerable<Historico>> GetAllHistoricosByUser(string user);		
	}
}
