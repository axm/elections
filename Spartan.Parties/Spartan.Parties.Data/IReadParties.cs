using System.Threading.Tasks;
using Spartan.Parties.Types.Requests;

namespace Spartan.Parties.Data
{
    public interface IReadParties
    {
        Task<GetPartyResponse> Get(GetPartyRequest request);
    }
}