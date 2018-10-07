using System;

namespace Spartan.Elections.Client.Queries.Requests
{
    public sealed class GetOpenElectionRequest
    {
        public Guid ElectionId { get; set; }
    }
}
