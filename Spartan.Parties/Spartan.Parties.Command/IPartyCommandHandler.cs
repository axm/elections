using System.Threading.Tasks;
using Spartan.Parties.Types.Requests;

namespace Spartan.Parties.Command
{
    internal interface IPartyCommandHandler
    {
        Task Create(CreatePartyRequest request);
    }
}