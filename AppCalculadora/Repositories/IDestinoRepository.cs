using AppCalculadora.Shared;

namespace AppCalculadora.Repositories
{
    public interface IDestinoRepository
    {
        Task<bool> InsertDestino(Destino destino);
        Task<bool> UpdateDestino(Destino destino);
        Task DeleteDestino(int id);
        Task<IEnumerable<Destino>> GetAllDestino();
        Task<Destino> GetDestinoById(int id);
    }
}
