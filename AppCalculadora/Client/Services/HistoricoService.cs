using AppCalculadora.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.RegularExpressions;

namespace AppCalculadora.Client.Services
{
    public class HistoricoService : IHistoricoService
	{
        private readonly HttpClient _httpClient;
        public HistoricoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Historico>> GetAllHistoricos()
        {
           return await _httpClient.GetFromJsonAsync<IEnumerable<Historico>>($"api/Historicos");		   
		}

        public async Task<IEnumerable<Historico>> GetAllHistoricosByUser(string user)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Historico>>($"api/Historicos/{user}");            
        }
		public async Task SaveHistorico(Historico historico)
		{
			if (historico.idHistorico == 0)
				// insertar
				await _httpClient.PostAsJsonAsync<Historico>($"api/Historicos", historico);			    
		}
	}
}