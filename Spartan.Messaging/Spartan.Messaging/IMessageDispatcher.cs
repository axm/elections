using System;
using System.Threading.Tasks;

namespace Spartan.Messaging
{
    public interface IMessageDispatcher<T> : IDisposable where T: class
    {
        Task DispatchAsync(T data);
    }
}
