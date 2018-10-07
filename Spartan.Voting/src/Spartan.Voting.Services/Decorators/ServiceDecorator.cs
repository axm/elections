using System;
using System.Threading.Tasks;

namespace Spartan.Voting.Services
{
    public sealed class ServiceDecorator<TService>
    {
        private readonly TService _service;

        public ServiceDecorator(TService service)
            => _service = service;

        public Task<TReturn> ExecuteAsync<TReturn>(Func<TService, Task<TReturn>> func)
        {
            return func.Invoke(_service);
        }
    }
}
