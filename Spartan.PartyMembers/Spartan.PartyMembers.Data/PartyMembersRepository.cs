using Dapper;
using Spartan.PartyMembers.Command.Client.Requests;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Transactions;

namespace Spartan.PartyMembers.Data
{
    internal sealed class PartyMembersRepository : IPartyMembersRepository
    {
        /// <inheritdoc/>
        public async Task AddPartyMember(AddPartyMemberRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            using (var transactionScope = new TransactionScope())
            using (var sqlConnection = new SqlConnection(""))
            {
                await sqlConnection.ExecuteAsync("uspAddPartyMember", new { request.PartyId, request.PersonId }, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }

}
