using System;

namespace Spartan.Elections.Events
{
    public sealed class ElectionArchivedEvent
    {
        public Guid ElectionId { get; set; }
    }
}
