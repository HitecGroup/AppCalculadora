using AppCalculadora.Shared;
using System.Net.Http.Json;

namespace AppCalculadora.Client.Services
{
    public class CalculoService : ICalculoService
    {
        private readonly HttpClient _httpClient;
        public CalculoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

		public async Task<Calculo> GetCalculo(int idModelo, int vIncoterm, int idDestino, double vCosto)
		{
			return await _httpClient.GetFromJsonAsync<Calculo>($"api/calculos/{idModelo}/{vIncoterm}/{idDestino}/{vCosto}");
		}
	}
}
