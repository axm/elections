using System;
using System.Collections.Generic;
using System.Fabric;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Remoting.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using Spartan.Mappings;
using Spartan.PartyMembers.Command.Client;
using Spartan.PartyMembers.Command.Client.Requests;
using Spartan.PartyMembers.Services.Commands;
using Validation;

namespace Spartan.PartyMembers.CommandService
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class CommandService : StatelessService, IPartyMembersCommand
    {
        private readonly IPartyMembersCommandHandler _handler;
        private readonly IMappingService _mappingService;
        
        /// <exception cref="ArgumentNullException">Thrown either of <paramref name="context"/>, <paramref name="handler"/>, <paramref name="mappingService"/> is null.</exception>
        public CommandService(StatelessServiceContext context, IPartyMembersCommandHandler handler, IMappingService mappingService)
            : base(context)
        {
            Requires.NotNull(context, nameof(context));
            Requires.NotNull(handler, nameof(handler));
            Requires.NotNull(mappingService, nameof(mappingService));

            _handler = handler;
            _mappingService = mappingService;
        }

        /// <inheritdoc />
        public async Task AddPartyMember(AddPartyMemberRequest request)
        {
            Requires.NotNull(request, nameof(request));

            await _handler.AddPartyMember(request);
        }

        /// <summary>
        /// Optional override to create listeners (e.g., TCP, HTTP) for this service replica to handle client or user requests.
        /// </summary>
        /// <returns>A collection of listeners.</returns>
        protected override IEnumerable<ServiceInstanceListener> CreateServiceInstanceListeners() => this.CreateServiceRemotingInstanceListeners();
    }
}
