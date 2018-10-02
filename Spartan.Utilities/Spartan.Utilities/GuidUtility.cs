using System;

namespace Spartan.Utilities
{
    internal sealed class GuidUtility : IGuidUtility
    {
        /// <inheritdoc />
        public Guid NewGuid() => Guid.NewGuid();
    }
}