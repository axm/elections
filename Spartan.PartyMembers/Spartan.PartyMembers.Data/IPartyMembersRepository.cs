using Spartan.PartyMembers.Command.Client.Requests;
using System.Threading.Tasks;

namespace Spartan.PartyMembers.Data
{
    public interface IPartyMembersRepository
    {
        Task AddPartyMember(AddPartyMemberRequest request);
    }
}
