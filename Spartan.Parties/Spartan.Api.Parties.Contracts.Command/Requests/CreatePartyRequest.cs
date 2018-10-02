using System;

namespace Spartan.Api.Parties.Contracts.Command.Requests
{
    public class CreatePartyRequest
    {
        public Guid PartyId { get; set; }
        public string PartyRef { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; } = "UK";
    }
}
