using System;
using System.Configuration;
using Validation;

namespace Spartan.Utilities
{
    /// <inheritdoc />
    internal sealed class ConfigurationService : IConfigurationService
    {
        /// <inheritdoc />
        public string GetString(string key)
        {
            Requires.NotNullOrWhiteSpace(key, nameof(key));

            return ConfigurationManager.AppSettings[key];
        }

        /// <inheritdoc />
        public string GetConnectionString(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentException(nameof(key));
            }

            return ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }

        /// <inheritdoc />
        public T GetSection<T>(string sectionName) where T : class
        {
            if (string.IsNullOrWhiteSpace(sectionName))
            {
                throw new ArgumentException(nameof(sectionName));
            }

            return (T) ConfigurationManager.GetSection(sectionName);
        }
    }
}
