using System;
using System.Configuration;

namespace Spartan.Parties.Utilities
{
    internal sealed class ConfigurationService : IConfigurationService
    {
        public string GetConnectionString(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException(nameof(key));

            return ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }
    }
}