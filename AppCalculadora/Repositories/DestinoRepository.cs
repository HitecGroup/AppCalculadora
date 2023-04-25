using AppCalculadora.Shared;
using Dapper;
using System.Data;

namespace AppCalculadora.Repositories
{
    public class DestinoRepository : IDestinoRepository
	{
        private readonly IDbConnection _dbConnection;

        public DestinoRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task<bool> InsertDestino(Destino destino)
        {
            try
            {
                var sql = @"INSERT INTO Destinos (idDestino,idEstado,Ciudad) VALUES(@idDestino,@idEstado,@Ciudad)";
                var result = await _dbConnection.ExecuteAsync(sql, new
                {
                    destino.idDestino,
                    destino.idEstado,
                    destino.Ciudad
                });
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> UpdateDestino(Destino destino)
        {
            try
            {
                var sql = @"UPDATE Destinos SET idDestino = @idDestino, idEstado = @idEstado, Ciudad = @Ciudad WHERE idDestino = @idDestino";
                var result = await _dbConnection.ExecuteAsync(sql, new
                {   destino.idDestino,
                    destino.idEstado,
                    destino.Ciudad
                });

                return result > 0;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task DeleteDestino(int id)
        {
            var sql = @"DELETE FROM Destinos WHERE idDestino = @id";
            var result = await _dbConnection.ExecuteAsync(sql, new { id = id });
        }
        public async Task<IEnumerable<Destino>> GetAllDestino()
        {           
            var sql = @"SELECT idDestino,idEstado,Ciudad FROM Destinos";
            return await _dbConnection.QueryAsync<Destino>(sql, new {});            
        }
        public async Task<Destino> GetDestinoById(int id)
        {          
            var sql = @"SELECT idDestino,idEstado,Ciudad FROM Destinos WHERE idDestino = @id";
            return await _dbConnection.QueryFirstOrDefaultAsync<Destino>(sql, new{ id = id });
        }
    }
}