using AppCalculadora.Shared;

namespace AppCalculadora.Client.Services
{
    public interface IDestinoService
    {
        Task SaveDestino(Destino destino);
        Task DeleteDestino(int id);
        Task<IEnumerable<Destino>> GetAllDestino();
        Task <Destino> GetDestinoById(int id);
    }
}
