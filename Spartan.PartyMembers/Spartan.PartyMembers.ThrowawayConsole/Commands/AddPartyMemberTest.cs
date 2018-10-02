using Microsoft.ServiceFabric.Services.Remoting.Client;
using Spartan.PartyMembers.Command.Client;
using Spartan.PartyMembers.Command.Client.Requests;
using System;
using System.Threading.Tasks;

namespace Spartan.PartyMembers.ThrowawayConsole.Commands
{
    internal sealed class AddPartyMemberTest
    {
        private readonly Uri _commandServiceUri = new Uri(Constants.CommandServiceUri);

        public async Task Execute()
        {
            var request = new AddPartyMemberRequest
            {
                PartyId = Guid.NewGuid(),
                PersonId = Guid.NewGuid()
            };

            await ServiceProxy.Create<IPartyMembersCommand>(_commandServiceUri).AddPartyMember(request);
        }
    }
}
