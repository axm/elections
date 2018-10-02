using System;

namespace Spartan.Utilities
{
    public interface IConfigurationService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="key"/> is null.</exception>
        string GetString(string key);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="key"/> is null.</exception>
        string GetConnectionString(string key);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="sectionName"/> is null.</exception>
        T GetSection<T>(string sectionName) where T : class;
    }
}