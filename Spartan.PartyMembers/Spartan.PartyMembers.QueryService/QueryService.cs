using System;
using System.Collections.Generic;
using System.Fabric;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Remoting.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using Spartan.Mappings;
using Spartan.PartyMembers.Query.Client;
using Spartan.PartyMembers.Query.Client.Requests;
using Spartan.PartyMembers.Services;
using Validation;

namespace Spartan.PartyMembers.QueryService
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class QueryService : StatelessService, IPartyMembersQuery
    {
        private readonly IMappingService _mappingService;

        public QueryService(StatelessServiceContext context, IMappingService mappingService)
            : base(context)
        {
            Requires.NotNull(context, nameof(context));
            Requires.NotNull(mappingService, nameof(mappingService));

            _mappingService = mappingService;
        }

        public async Task<FindPartyMembersResponse> FindPartyMembers(FindPartyMembersRequest request)
        {
            Requires.NotNull(request, nameof(request));

            throw new NotImplementedException();
        }

        public Task<GetPartyMembersResponse> GetPartyMembers(GetPartyMembersRequest request)
        {
            Requires.NotNull(request, nameof(request));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Optional override to create listeners (e.g., TCP, HTTP) for this service replica to handle client or user requests.
        /// </summary>
        /// <returns>A collection of listeners.</returns>
        protected override IEnumerable<ServiceInstanceListener> CreateServiceInstanceListeners() => this.CreateServiceRemotingInstanceListeners();
    }
}
