using System.Configuration;

namespace Spartan.Blobs.Config
{
    public sealed class BlobStorageConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("connectionString", IsRequired = true)]
        public string Name
        {
            get
            {
                return (string)this["connectionString"];
            }
            set
            {
                this["connectionString"] = value;
            }
        }
    }
}
