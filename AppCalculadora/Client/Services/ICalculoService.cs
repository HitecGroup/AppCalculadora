using AppCalculadora.Shared;

namespace AppCalculadora.Client.Services
{
    public interface ICalculoService
    {
		Task<Calculo> GetCalculo(int idModelo, int vIncoterm, int idDestino, double vCosto);
	}
}
