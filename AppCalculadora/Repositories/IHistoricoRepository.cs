using AppCalculadora.Shared;

namespace AppCalculadora.Repositories
{
    public interface IHistoricoRepository
    {
        Task<bool> InsertHistorico(Historico historico);
        Task<IEnumerable<Historico>> GetAllHistoricos();
        Task<IEnumerable<Historico>> GetHistoricosByUser(string user);
	}
}