using System;

namespace Spartan.Persons.Command.Client.Requests
{
    public sealed class EditPersonRequest
    {
        public Guid PersonId { get; set; }
    }
}
