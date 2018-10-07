using System.Collections.Generic;
using System.Fabric;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using Spartan.ServiceFabric;
using Spartan.Voting.Client;
using Spartan.Voting.Client.Requests;
using Spartan.Voting.Services;
using Spartan.Voting.Services.Voting;

namespace Spartan.Voting.Command
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class Command : SpartanStatelessService, IVotingCommand
    {
        private readonly ServiceDecorator<IVotingCommandService> _votingServiceDecorator;

        public Command(StatelessServiceContext context)
            : base(context)
        {
            //_votingServiceDecorator = new ServiceDecorator<IVotingCommandService>(votingCommandService);
        }

        public Task VoteAsync(VoteRequest request)
            => _votingServiceDecorator.ExecuteAsync<VoteResponse>(svc => svc.VoteAsync(request));
    }
}
