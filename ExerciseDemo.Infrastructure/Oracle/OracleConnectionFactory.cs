using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
namespace ExerciseDemo.Infrastructure.Oracle
{
    public class OracleConnectionFactory
    {
        private readonly IConfiguration configuration;

        public OracleConnectionFactory(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public OracleConnection CreateConnection()
        {
            var connectionString = configuration.GetConnectionString("OracleConnection");

            return new OracleConnection(connectionString);
        }


    }
}
