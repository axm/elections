using Spartan.Parties.Types.Requests;

namespace Spartan.Parties.Validation
{
    public interface IPartyCommandValidator
    {
        void Validate(CreatePartyRequest request);
    }
}
