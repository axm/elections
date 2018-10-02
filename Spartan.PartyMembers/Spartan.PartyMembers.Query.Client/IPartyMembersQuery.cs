using Microsoft.ServiceFabric.Services.Remoting;
using Spartan.PartyMembers.Query.Client.Requests;
using System.Threading.Tasks;

namespace Spartan.PartyMembers.Query.Client
{
    public interface IPartyMembersQuery : IService
    {
        Task<FindPartyMembersResponse> FindPartyMembers(FindPartyMembersRequest request);
        Task<GetPartyMembersResponse> GetPartyMembers(GetPartyMembersRequest request);
    }
}
