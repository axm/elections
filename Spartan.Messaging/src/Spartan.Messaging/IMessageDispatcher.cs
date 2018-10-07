using System;
using System.Threading.Tasks;

namespace Spartan.Messaging
{
    public interface IMessageDispatcher
    {
        Task DispatchAsync<T>(T data) where T : class;
    }
}
