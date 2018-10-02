using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Validation;

namespace Elections.Candidates.Data
{
    internal sealed class DbContainer : IDbContainer
    {
        private readonly string _connection;

        public DbContainer(string connection)
        {
            Requires.NotNull(connection, nameof(connection));

            _connection = connection;
        }

        public async Task<IDbConnection> GetReadOnlyConnection()
        {
            using (var connection = new SqlConnection(_connection))
            {
                await connection.OpenAsync();

                return connection;
            }
        }

        public async Task<IDbTransaction> GetReadWriteConnection()
        {
            using (var connection = new SqlConnection(_connection))
            {
                await connection.OpenAsync();

                return connection.BeginTransaction();
            }
        }
    }
}
