using Dapper;
using Spartan.Persons.Command.Client.Requests;
using System;
using System.Threading.Tasks;
using Validation;

namespace Spartan.Persons.Data
{
    internal sealed class PersonsRepository : IPersonsRepository
    {
        private readonly IDatabaseConnection _databaseConnection;

        public PersonsRepository(IDatabaseConnection databaseConnection)
        {
            Requires.NotNull(databaseConnection, nameof(databaseConnection));

            _databaseConnection = databaseConnection;
        }

        public async Task Archive(Guid personId)
        {
            using (var transaction = await _databaseConnection.GetConnection())
            {
                await transaction.Connection.ExecuteAsync("dbo.uspArchivePerson", new { personId }, transaction: transaction, commandType: System.Data.CommandType.StoredProcedure);

                transaction.Commit();
            }
        }

        public async Task Create(CreatePersonRequest request)
        {
            using (var transaction = await _databaseConnection.GetConnection())
            {
                await transaction.Connection.ExecuteAsync("dbo.uspCreatePerson", request, transaction: transaction, commandType: System.Data.CommandType.StoredProcedure);

                transaction.Commit();
            }
        }

        public async Task Edit(EditPersonRequest request)
        {
            using (var transaction = await _databaseConnection.GetConnection())
            {
                await transaction.Connection.ExecuteAsync("dbo.uspEditPerson", request, transaction: transaction, commandType: System.Data.CommandType.StoredProcedure);

                transaction.Commit();
            }
        }
    }
}
