using AppCalculadora.Shared;
using Dapper;
using System.Data;

namespace AppCalculadora.Repositories
{
    public class IncotermRepository : IIncotermRepository
	{
        private readonly IDbConnection _dbConnection;
        public IncotermRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task<IEnumerable<Incoterm>> GetAllIncoterm()
        {           
            var sql = @"SELECT IdIncoterms,Clave FROM Incoterms";
            return await _dbConnection.QueryAsync<Incoterm>(sql, new {});            
        }
    }
}