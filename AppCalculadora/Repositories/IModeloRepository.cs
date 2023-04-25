using AppCalculadora.Shared;

namespace AppCalculadora.Repositories
{
    public interface IModeloRepository
    {
        Task<IEnumerable<Modelo>> GetAllModelos();
        Task<IEnumerable<Modelo>> GetAllModelosByMarca(int id);
    }
}
