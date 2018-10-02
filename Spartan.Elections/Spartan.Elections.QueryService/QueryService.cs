using System.Collections.Generic;
using System.Fabric;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Remoting.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using Spartan.Elections.Query.Client;
using Spartan.Elections.Query.Client.Requests;
using Validation;

namespace Spartan.Elections.QueryService
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class QueryService : StatelessService, IElectionsQueryService
    {
        public QueryService(StatelessServiceContext context)
            : base(context)
        { }

        public Task<GetElectionResponse> GetElection(GetElectionRequest request)
        {
            Requires.NotNull(request, nameof(request));

            throw new System.NotImplementedException();
        }

        public Task<GetElectionsResponse> GetElections(GetElectionsRequest request)
        {
            Requires.NotNull(request, nameof(request));

            throw new System.NotImplementedException();
        }

        protected override IEnumerable<ServiceInstanceListener> CreateServiceInstanceListeners()
        {
            return this.CreateServiceRemotingInstanceListeners();
        }
    }
}
