using Spartan.PartyMembers.Command.Client.Requests;
using System.Threading.Tasks;

namespace Spartan.PartyMembers.Services.Commands
{
    public interface IPartyMembersCommandHandler
    {
        /// <summary>
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="request"/> is null.</exception>
        Task AddPartyMember(AddPartyMemberRequest request);
    }
}
