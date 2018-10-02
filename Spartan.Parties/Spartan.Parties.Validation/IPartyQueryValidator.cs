using Spartan.Parties.Types.Requests;

namespace Spartan.Parties.Validation
{
    public interface IPartyQueryValidator
    {
        void Validate(GetPartyRequest request);
    }
}