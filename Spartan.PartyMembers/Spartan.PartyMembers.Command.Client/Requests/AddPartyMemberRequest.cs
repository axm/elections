using System;

namespace Spartan.PartyMembers.Command.Client.Requests
{
    public sealed class AddPartyMemberRequest
    {
        /// <summary>
        /// The id of the party.
        /// </summary>
        public Guid PartyId { get; set; }

        /// <summary>
        /// The id of the person to be added to the party.
        /// </summary>
        public Guid PersonId { get; set; }
    }
}
