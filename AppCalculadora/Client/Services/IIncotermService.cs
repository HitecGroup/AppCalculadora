using AppCalculadora.Shared;

namespace AppCalculadora.Client.Services
{
    public interface IIncotermService
	{
        Task<IEnumerable<Incoterm>> GetAllIncoterm();
    }
}
