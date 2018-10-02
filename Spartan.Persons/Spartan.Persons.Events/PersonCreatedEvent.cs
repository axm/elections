using System;

namespace Spartan.Persons.Events
{
    public sealed class PersonCreatedEvent
    {
        public Guid PersonId { get; set; }
    }
}
