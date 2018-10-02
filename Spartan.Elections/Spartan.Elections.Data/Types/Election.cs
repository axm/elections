using System;

namespace Spartan.Elections.Data.Types
{
    public sealed class Election
    {
        public Guid ElectionId { get; set; }
        public string ContainerName { get; set; }

        public string TimestampCreated { get; set; }
    }
}
