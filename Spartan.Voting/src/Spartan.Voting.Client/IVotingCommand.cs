using Microsoft.ServiceFabric.Services.Remoting;
using Spartan.Voting.Client.Requests;
using System.Threading.Tasks;

namespace Spartan.Voting.Client
{
    public interface IVotingCommand : IService
    {
        Task VoteAsync(VoteRequest request);
    }
}
