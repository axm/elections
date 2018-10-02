using System.Fabric;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Runtime;
using Spartan.Candidates.Query.Client;
using Spartan.Candidates.Query.Client.Requests;
using Validation;

namespace Spartan.Candidates.QueryService
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class QueryService : StatelessService, ICandidatesQueryService
    {
        /// <summary>
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="context"/> is null.</exception>
        public QueryService(StatelessServiceContext context)
            : base(context)
        {
            Requires.NotNull(context, nameof(context));
        }

        /// <inheritdoc />
        public Task<GetCandidateResponse> GetCandidate(GetCandidateRequest request)
        {
            Requires.NotNull(request, nameof(request));

            throw new System.NotImplementedException();
        }
    }
}
