using System;

namespace Spartan.Candidates.Events
{
    public sealed class CandidateCreatedEvent
    {
        public Guid CandidateId { get; set; }
        public DateTime TimestampCreated { get; set; }
    }
}
