using AppCalculadora.Shared;
using System.Net.Http.Json;

namespace AppCalculadora.Client.Services
{
    public class DestinoService : IDestinoService
    {
        private readonly HttpClient _httpClient;
        public DestinoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task DeleteDestino(int id)
        {
            await _httpClient.DeleteAsync($"api/destinos/{id}");
        }

        public async Task<IEnumerable<Destino>> GetAllDestino()
        {
           return await _httpClient.GetFromJsonAsync<IEnumerable<Destino>>($"api/destinos/");
        }

        public async Task<Destino> GetDestinoById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Destino>($"api/destinos/{id}");
        }

        public async Task SaveDestino(Destino destino)
        {
            if (destino.idDestino == 0)
                // insertar
                await _httpClient.PostAsJsonAsync<Destino>($"api/destinos/", destino);
            else
                // editar
               await _httpClient.PutAsJsonAsync<Destino>($"api/destinos/{destino.idDestino}", destino);
        }
    }
}
