using System;

namespace Spartan.Voting.Client.Requests
{
    public sealed class VoteRequest
    {
        public Guid ElectionId { get; set; }
        public DateTimeOffset Timestamp { get; set; }
        public object Data { get; set; }
    }
}
