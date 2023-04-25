using AppCalculadora.Shared;
using System.Net.Http.Json;

namespace AppCalculadora.Client.Services
{
    public class IncotermService : IIncotermService
	{
        private readonly HttpClient _httpClient;
        public IncotermService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
       
        public async Task<IEnumerable<Incoterm>> GetAllIncoterm()
        {
           return await _httpClient.GetFromJsonAsync<IEnumerable<Incoterm>>($"api/Incoterm/");
        }

    }
}
