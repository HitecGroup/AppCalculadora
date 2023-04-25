using AppCalculadora.Shared;

namespace AppCalculadora.Repositories
{
    public interface ICalculoRepository
    {
		Task<Calculo> GetCalculo(int idModelo, int vIncoterm, int idDestino, double vCosto);
	}
}
