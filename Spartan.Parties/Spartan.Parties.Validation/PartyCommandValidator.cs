using System;
using Spartan.Parties.Types.Requests;

namespace Spartan.Parties.Validation
{
    internal sealed class PartyCommandValidator : IPartyCommandValidator
    {
        public void Validate(CreatePartyRequest request)
        {
            if(request == null)
                throw new ArgumentNullException(nameof(request));
        }
    }
}