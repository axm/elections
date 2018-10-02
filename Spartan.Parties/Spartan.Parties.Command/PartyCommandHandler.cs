using System;
using System.Threading.Tasks;
using Spartan.Parties.Data;
using Spartan.Parties.Types.Requests;
using Spartan.Parties.Validation;

namespace Spartan.Parties.Command
{
    internal sealed class PartyCommandHandler : IPartyCommandHandler
    {
        private readonly IPartyCommandValidator _validator;
        private readonly IWriteParties _writeParties;

        public PartyCommandHandler(IPartyCommandValidator validator, IWriteParties writeParties)
        {
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
            _writeParties = writeParties ?? throw new ArgumentNullException(nameof(writeParties));
        }

        public async Task Create(CreatePartyRequest request)
        {
            _validator.Validate(request);

            await _writeParties.Create(request);
        }
    }
}