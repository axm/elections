using System;
using System.Collections.Generic;
using System.Fabric;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Remoting.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using Spartan.Api.Parties.Contracts.Command;
using Spartan.Api.Parties.Contracts.Command.Requests;
using Spartan.Parties.Converters;

namespace Spartan.Parties.Command
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class PartyCommand : StatelessService, IPartiesCommand
    {
        private readonly IPartyRequestsConverter _converter;
        private readonly IPartyCommandHandler _handler;

        public PartyCommand(StatelessServiceContext context, IPartyRequestsConverter converter, IPartyCommandHandler handler)
            : base(context)
        {
            _converter = converter ?? throw new ArgumentNullException(nameof(converter));
            _handler = handler ?? throw new ArgumentNullException(nameof(handler));
        }

        /// <summary>
        /// Optional override to create listeners (e.g., TCP, HTTP) for this service replica to handle client or user requests.
        /// </summary>
        /// <returns>A collection of listeners.</returns>
        protected override IEnumerable<ServiceInstanceListener> CreateServiceInstanceListeners()
        {
            return new[] { new ServiceInstanceListener(this.CreateServiceRemotingListener) };
        }

        public async Task Create(CreatePartyRequest createPartyRequest)
        {
            var request = _converter.Convert(createPartyRequest);

            await _handler.Create(request);
        }
    }
}
