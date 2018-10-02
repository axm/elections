using System;
using System.Collections.Generic;
using System.Text;

namespace Spartan.Precincts.Client.Events
{
    public sealed class PrecinctVoteCompleteEvent
    {
        public string PrecinctId { get; set; }
        public DateTimeOffset EventTimestamp { get; set; }
    }
}
