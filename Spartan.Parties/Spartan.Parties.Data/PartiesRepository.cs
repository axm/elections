using System;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Spartan.Parties.Types.Requests;

namespace Spartan.Parties.Data
{
    public class PartiesRepository : IPartiesRepository
    {
        private readonly IPartiesDatabase _database;

        public PartiesRepository(IPartiesDatabase database)
        {
            _database = database ?? throw new ArgumentNullException(nameof(database));
        }

        public async Task AddToElection(Guid electionId, Guid partyId)
        {
            using (var transaction = await _database.GetReadWriteConnection())
            {
                await transaction.Connection.ExecuteAsync("spAddPartyToElection", new { ElectionId = electionId, @PartyId = partyId }, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task Create(CreatePartyRequest request)
        {
            using (var transaction = await _database.GetReadWriteConnection())
            {
                await transaction.Connection.ExecuteAsync("spCreateParty", new { CountryCode = "USA", request.PartyId, PartyName = request.Name }, commandType:  CommandType.StoredProcedure);
            }
        }
    }
}
