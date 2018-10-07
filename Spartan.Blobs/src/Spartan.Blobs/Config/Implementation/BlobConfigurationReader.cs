using System.Configuration;

namespace Spartan.Blobs.Config.Implementation
{
    /// <inheritdoc />
    public sealed class BlobConfigurationReader : IBlobConfigurationReader
    {
        /// <inheritdoc />
        public string GetConnectionString() => ConfigurationManager.AppSettings["StorageConnectionString"];
    }
}
