using System;
using System.Threading.Tasks;

namespace Spartan.Caching
{
    public interface ICaching
    {
        Task<T> TryGetValueAsync<T>(string key) where T: class;
        Task SetValueAsync<T>(string key, T value) where T : class;
    }
}
