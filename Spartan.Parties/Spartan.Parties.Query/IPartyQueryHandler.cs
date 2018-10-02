using System.Threading.Tasks;
using Spartan.Parties.Types.Requests;

namespace Spartan.Parties.Query
{
    internal interface IPartyQueryHandler
    {
        Task<GetPartyResponse> GetParty(GetPartyRequest request);
    }
}