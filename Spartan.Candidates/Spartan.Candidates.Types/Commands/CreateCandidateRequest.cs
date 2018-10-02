using System;

namespace Spartan.Candidates.Types.Commands
{
    public sealed class CreateCandidateRequest
    {
        public Guid CandidateId { get; set; }
        public Guid ElectionId { get; set; }
        public Guid PartyId { get; set; }
        public Guid PersonId { get; set; }
    }
}
