using Spartan.PartyMembers.Command.Client.Requests;

namespace Spartan.PartyMembers.Validation
{
    public interface IPartyMembersCommandValidator
    {
        void Validate(AddPartyMemberRequest request);
    }
}
