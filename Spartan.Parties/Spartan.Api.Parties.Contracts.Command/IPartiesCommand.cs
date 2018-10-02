using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Remoting;
using Spartan.Api.Parties.Contracts.Command.Requests;

namespace Spartan.Api.Parties.Contracts.Command
{
    public interface IPartiesCommand : IService
    {
        Task Create(CreatePartyRequest createPartyRequest);
    }
}
