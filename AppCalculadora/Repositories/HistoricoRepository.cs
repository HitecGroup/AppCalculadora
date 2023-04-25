using AppCalculadora.Shared;
using Dapper;
using System.Data;
using System.Data.Common;

namespace AppCalculadora.Repositories
{
    public class HistoricoRepository : IHistoricoRepository
	{
        private readonly IDbConnection _dbConnection;

        public HistoricoRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task<bool> InsertHistorico(Historico historico)
        {
            try
            {
                var sql = @"INSERT INTO Historico (Usuario,Fecha,Marca,Modelo,Incoterm,Destino,Costo,Seguro,SeguroProfit,FleteMar,FleteMarProfit,FleteTer,FleteTerProfit,ImpuestoA,ImpuestoAProfit,Aam,AamProfit,Maniobras,ManiobrasProfit,Gl,GlProfit,Total,TotalProfit,VigenciaMaritimo,VigenciaTerrestre) VALUES (@Usuario,@Fecha,@Marca,@Modelo,@Incoterm,@Destino,@Costo,@Seguro,@SeguroProfit,@FleteMar,@FleteMarProfit,@FleteTer,@FleteTerProfit,@ImpuestoA,@ImpuestoAProfit,@Aam,@AamProfit,@Maniobras,@ManiobrasProfit,@Gl,@GlProfit,@Total,@TotalProfit,@VigenciaMaritimo,@VigenciaTerrestre)";
                var result = await _dbConnection.ExecuteAsync(sql, new
                {
					historico.Usuario,
					historico.Fecha,
					historico.Marca,
					historico.Modelo,
					historico.Incoterm,
					historico.Destino,
					historico.Costo,
					historico.Seguro,
					historico.SeguroProfit,
					historico.FleteMar,
					historico.FleteMarProfit,
					historico.FleteTer,
					historico.FleteTerProfit,
					historico.ImpuestoA,
					historico.ImpuestoAProfit,
					historico.Aam,
					historico.AamProfit,
					historico.Maniobras,
					historico.ManiobrasProfit,
					historico.Gl,
					historico.GlProfit,
					historico.Total,
					historico.TotalProfit,
					historico.VigenciaMaritimo,
					historico.VigenciaTerrestre
				});
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<Historico>> GetAllHistoricos()
        {           
            var sql = @"SELECT idHistorico,Usuario,Fecha,Marca,Modelo,Incoterm,Destino,Costo,Seguro,SeguroProfit,FleteMar,FleteMarProfit,FleteTer,FleteTerProfit,ImpuestoA,ImpuestoAProfit,Aam,AamProfit,Maniobras,ManiobrasProfit,Gl,GlProfit,Total,TotalProfit,VigenciaMaritimo,VigenciaTerrestre FROM Historico";
            return await _dbConnection.QueryAsync<Historico>(sql, new {});            
        }		
		public async Task<IEnumerable<Historico>> GetHistoricosByUser(string user)
        {          
            var sql = @"SELECT idHistorico,Usuario,Fecha,Marca,Modelo,Incoterm,Destino,Costo,Seguro,SeguroProfit,FleteMar,FleteMarProfit,FleteTer,FleteTerProfit,ImpuestoA,ImpuestoAProfit,Aam,AamProfit,Maniobras,ManiobrasProfit,Gl,GlProfit,Total,TotalProfit,VigenciaMaritimo,VigenciaTerrestre FROM Historico WHERE usuario = @usuario ORDER BY fecha DESC";
            return await _dbConnection.QueryAsync<Historico>(sql, new{ usuario = user });
        }
    }
}