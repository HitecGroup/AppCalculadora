using AppCalculadora.Shared;

namespace AppCalculadora.Repositories
{
    public interface IMarcaRepository
    {
        Task<bool> InsertMarca(Marca marca);
        Task<bool> UpdateMarca(Marca marca);
        Task DeleteMarca(int id);
        Task<IEnumerable<Marca>> GetAllMarca();
        Task<Marca> GetMarcaById(int id);
    }
}
