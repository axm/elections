using System;
using System.Collections.Generic;
using System.Fabric;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Remoting.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using Spartan.Api.Parties.Contracts.Query;
using Spartan.Api.Parties.Contracts.Query.Requests;
using Spartan.Parties.Converters;

namespace Spartan.Parties.Query
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class PartiesQuery : StatelessService, IPartiesQuery
    {
        private readonly IPartyQueryHandler _handler;
        private readonly IPartyRequestsConverter _converter;

        public PartiesQuery(StatelessServiceContext context, IPartyQueryHandler handler, IPartyRequestsConverter converter)
            : base(context)
        {
            _handler = handler ?? throw new ArgumentNullException(nameof(handler));
            _converter = converter;
        }

        /// <summary>
        /// Optional override to create listeners (e.g., TCP, HTTP) for this service replica to handle client or user requests.
        /// </summary>
        /// <returns>A collection of listeners.</returns>
        protected override IEnumerable<ServiceInstanceListener> CreateServiceInstanceListeners()
        {
            return new[] { new ServiceInstanceListener(this.CreateServiceRemotingListener) };
        }

        /// <inheritdoc />
        public async Task<GetPartyResponse> GetParty(GetPartyRequest request)
        {
            return _converter.Convert(await _handler.GetParty(_converter.Convert(request)));
        }
    }
}
