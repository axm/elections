using System;

namespace Spartan.Persons.Command.Client.Requests
{
    public sealed class CreatePersonRequest
    {
        public Guid PersonId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
