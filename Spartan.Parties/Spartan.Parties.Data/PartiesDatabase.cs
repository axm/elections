using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Spartan.Utilities;

namespace Spartan.Parties.Data
{
    public class PartiesDatabase : IPartiesDatabase
    {
        private readonly string _readOnlyConnection;
        private readonly string _readWriteConnection;

        public PartiesDatabase(IConfigurationService configurationService)
        {
            if(configurationService == null)
                throw new ArgumentNullException(nameof(configurationService));

            _readOnlyConnection = configurationService.GetConnectionString("PartiesReadOnly");
            _readWriteConnection = configurationService.GetConnectionString("PartiesReadWrite");
        }

        public async Task<IDbConnection> GetReadOnlyConnection()
        {
            using (var connection = new SqlConnection(_readOnlyConnection))
            {
                await connection.OpenAsync();

                return connection;
            }
        }

        public async Task<IDbTransaction> GetReadWriteConnection()
        {
            using (var connection = new SqlConnection(_readWriteConnection))
            using (var transaction = connection.BeginTransaction())
            {
                await connection.OpenAsync();

                return transaction;
            }
        }
    }
}