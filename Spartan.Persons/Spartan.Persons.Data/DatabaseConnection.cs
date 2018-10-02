using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Spartan.Persons.Data
{
    public sealed class DatabaseConnection : IDatabaseConnection
    {
        private readonly string _connectionString;
        private const string ConnectionKey = "PersonsConnection";

        public DatabaseConnection(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public async Task<IDbTransaction> GetConnection()
        {
            var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();
            return connection.BeginTransaction();
        }
    }
}
