using System;

namespace Spartan.Elections.Events
{
    public sealed class ElectionCreatedEvent
    {
        public Guid ElectionId { get; set; }
    }
}
