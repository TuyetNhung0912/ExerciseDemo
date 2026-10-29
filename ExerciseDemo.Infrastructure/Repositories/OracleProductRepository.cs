using Dapper;
using Dapper.Oracle;
using ExerciseDemo.Application.Interfaces;
using ExerciseDemo.Domain.Entities;
using ExerciseDemo.Infrastructure.Oracle;
using System.Data;
namespace ExerciseDemo.Infrastructure.Repositories
{
    public class OracleProductRepository: IProductRepository
    {
        private readonly OracleConnectionFactory oracleConnectionFactory;

        public OracleProductRepository(OracleConnectionFactory oracleConnectionFactory)
        {
            this.oracleConnectionFactory = oracleConnectionFactory;
        }
        public async Task<List<Product>?> GetHistoryNotOk(int supId,CancellationToken cancellationToken)
        {
            await using var connection = oracleConnectionFactory.CreateConnection();
            var parameters = new OracleDynamicParameters();
            parameters.Add("p_SupId", supId);
            parameters.Add(  "p_Result");
            var result = await connection.QueryAsync <Product>(new CommandDefinition(
                commandText: "PAR.OSU4R_TKBTv2_Deployment_GetHistoryDeploymentNotOk",
                parameters: parameters,
                commandType: CommandType.StoredProcedure,
                cancellationToken: cancellationToken));
            return result.ToList();
        }
    }
}
