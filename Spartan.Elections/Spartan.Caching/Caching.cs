using Newtonsoft.Json;
using StackExchange.Redis;
using System.Threading.Tasks;

namespace Spartan.Caching
{
    public sealed class Caching : ICaching
    {
        private readonly IDatabase _database;

        public Caching(IDatabase database)
        {
            _database = database;
        }

        public Task SetValueAsync<T>(string key, T value) where T : class => _database.StringSetAsync(key, JsonConvert.SerializeObject(value));

        public async Task<T> TryGetValueAsync<T>(string key) where T : class
        {
            var result = await _database.StringGetAsync(key);

            if(!result.HasValue)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}
