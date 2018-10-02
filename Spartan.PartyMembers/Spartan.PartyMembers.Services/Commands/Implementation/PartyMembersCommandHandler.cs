using System.Threading.Tasks;
using Spartan.PartyMembers.Command.Client.Requests;
using Spartan.PartyMembers.Data;
using Spartan.PartyMembers.Validation;
using Validation;

namespace Spartan.PartyMembers.Services.Commands.Implementation
{
    internal sealed class PartyMembersCommandHandler : IPartyMembersCommandHandler
    {
        private readonly IPartyMembersRepository _writer;
        private readonly IPartyMembersCommandValidator _validator;

        public PartyMembersCommandHandler(IPartyMembersRepository writer, IPartyMembersCommandValidator validator)
        {
            Requires.NotNull(writer, nameof(writer));
            Requires.NotNull(validator, nameof(validator));

            _writer = writer;
            _validator = validator;
        }

        /// <inheritdoc />
        public Task AddPartyMember(AddPartyMemberRequest request)
        {
            Requires.NotNull(request, nameof(request));

            _validator.Validate(request);

            return _writer.AddPartyMember(request);
        }
    }
}
