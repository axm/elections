using System;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Spartan.Parties.Types.Requests;

namespace Spartan.Parties.Data
{
    internal sealed class ReadParties : IReadParties
    {
        private readonly IPartiesDatabase _database;

        public ReadParties(IPartiesDatabase database)
        {
            _database = database ?? throw new ArgumentNullException(nameof(database));
        }

        public async Task<GetPartyResponse> Get(GetPartyRequest request)
        {
            if(request == null)
                throw new ArgumentNullException(nameof(request));

            using (var connection = await _database.GetReadOnlyConnection())
            {
                var param = new DynamicParameters();
                return connection.QuerySingleOrDefault<GetPartyResponse>("dbo.uspGetParty", param,
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}