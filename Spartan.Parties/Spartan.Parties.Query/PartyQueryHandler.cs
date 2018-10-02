using System.Threading.Tasks;
using Spartan.Parties.Data;
using Spartan.Parties.Types.Requests;
using Spartan.Parties.Validation;
using Validation;

namespace Spartan.Parties.Query
{
    internal sealed class PartyQueryHandler : IPartyQueryHandler
    {
        private readonly IReadParties _readParties;
        private readonly IPartyQueryValidator _validator;
        private readonly IReadPermissions _permissions;

        public PartyQueryHandler(IReadParties readParties, IPartyQueryValidator validator, IReadPermissions permissions)
        {
            Requires.NotNull(readParties, nameof(readParties));
            Requires.NotNull(validator, nameof(validator));
            Requires.NotNull(permissions, nameof(permissions));

            _readParties = readParties;
            _validator = validator;
            _permissions = permissions;
        }

        public async Task<GetPartyResponse> GetParty(GetPartyRequest request)
        {
            _validator.Validate(request);

            return await _readParties.Get(request);
        }
    }
}