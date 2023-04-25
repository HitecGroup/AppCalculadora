﻿using AppCalculadora.Shared;

namespace AppCalculadora.Client.Services
{
    public interface IMarcaService
    {
        Task SaveMarca(Marca marca);
        Task DeleteMarca(int id);
        Task<IEnumerable<Marca>> GetAllMarca();
        Task <Marca> GetMarcaById(int id);
    }
}
