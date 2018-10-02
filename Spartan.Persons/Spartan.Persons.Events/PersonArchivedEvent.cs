using System;

namespace Spartan.Persons.Events
{
    public sealed class PersonArchivedEvent
    {
        public Guid PersonId { get; set; }
        public DateTime TimestampCreated { get; set; }
    }
}
