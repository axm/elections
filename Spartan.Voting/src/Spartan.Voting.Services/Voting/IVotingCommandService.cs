using Spartan.Voting.Client.Requests;
using System.Threading.Tasks;

namespace Spartan.Voting.Services.Voting
{
    public interface IVotingCommandService
    {
        Task<VoteResponse> VoteAsync(VoteRequest request);
    }
}
