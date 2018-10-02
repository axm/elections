using System.Threading.Tasks;
using Dapper;
using Spartan.Candidates.Types.Commands;
using Validation;

namespace Elections.Candidates.Data
{
    internal sealed class CandidatesRepository : ICandidatesRepository
    {
        private readonly IDbContainer _container;

        public CandidatesRepository(IDbContainer container)
        {
            Requires.NotNull(container, nameof(container));

            _container = container;
        }

        public async Task CreateCandidate(CreateCandidateRequest request)
        {
            Requires.NotNull(request, nameof(request));

            using (var transaction = await _container.GetReadWriteConnection())
            {
                await transaction.Connection.ExecuteAsync("dbo.uspCreateCandidate", request, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
