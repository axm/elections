using System;

namespace Spartan.Utilities
{
    public interface IGuidUtility
    {
        /// <summary>
        /// Generates a new random <see cref="Guid"/>.
        /// </summary>
        Guid NewGuid();
    }
}