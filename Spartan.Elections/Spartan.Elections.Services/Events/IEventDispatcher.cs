using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartan.Elections.Services.Events
{
    public interface IEventDispatcher<T>
    {
        Task DispatchAsync(T item);
    }

    public sealed class EventDispatcher<T> : IEventDispatcher<T>
    {
        public Task DispatchAsync(T item)
        {

            throw new NotImplementedException();
        }
    }
}
