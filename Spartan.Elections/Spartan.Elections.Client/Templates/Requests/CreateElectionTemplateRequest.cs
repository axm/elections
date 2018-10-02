using System;

namespace Spartan.Elections.Client.Templates.Requests
{
    public sealed class CreateElectionTemplateRequest
    {
        public Guid Id { get; set; }
        public object ElectionData { get; set; }
    }
}
