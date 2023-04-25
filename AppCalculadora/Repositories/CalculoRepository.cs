using AppCalculadora.Shared;
using Dapper;
using System.Data;

namespace AppCalculadora.Repositories
{
    public class CalculoRepository : ICalculoRepository
    {
        private readonly IDbConnection _dbConnection;

        public CalculoRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
		public async Task<Calculo> GetCalculo(int idModelo, int vIncoterm, int idDestino, double vCosto)
		{
			var sql = @"dbo.CalcularCostosv1";
			
			var param = new DynamicParameters();
			param.Add("@modelo", idModelo);
			param.Add("@incoterm", vIncoterm);
			param.Add("@destino", idDestino);
			param.Add("@costo", vCosto);			
			return await _dbConnection.QueryFirstOrDefaultAsync<Calculo>(sql, param, commandType: CommandType.StoredProcedure);
		}
	}
}