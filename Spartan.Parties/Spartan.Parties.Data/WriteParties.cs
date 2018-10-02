using System;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Spartan.Parties.Types.Requests;

namespace Spartan.Parties.Data
{
    internal sealed class WriteParties : IWriteParties
    {
        private readonly IPartiesDatabase _database;

        public WriteParties(IPartiesDatabase database)
        {
            _database = database ?? throw new ArgumentNullException(nameof(database));
        }

        /// <inheritdoc />
        public async Task Create(CreatePartyRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            using (var transaction = await _database.GetReadWriteConnection())
            {
                var dynamicParams = new DynamicParameters();
                dynamicParams.Add("@PartyId", request.PartyId);
                dynamicParams.Add("@PartyRef", request.PartyRef);
                dynamicParams.Add("@Name", request.Name);
                dynamicParams.Add("@CountryCode", request.CountryCode);

                await transaction.Connection.ExecuteAsync("dbo.uspCreateParty", dynamicParams, commandType: CommandType.StoredProcedure);
            }
        }
    }
}