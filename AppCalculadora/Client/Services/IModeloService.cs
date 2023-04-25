using AppCalculadora.Shared;

namespace AppCalculadora.Client.Services
{
    public interface IModeloService
    {
        Task<IEnumerable<Modelo>> GetAllModelos();
        Task<IEnumerable<Modelo>> GetAllModelosByMarca(int id);
    }
}
