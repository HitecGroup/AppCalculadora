using AppCalculadora.Shared;

namespace AppCalculadora.Repositories
{
    public interface IIncotermRepository
	{
        Task<IEnumerable<Incoterm>> GetAllIncoterm();
    }
}
