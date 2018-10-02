using RabbitMQ.Client;
using Spartan.Messaging.RabbitMq;
using Spartan.Serialization;
using System;
using System.Threading.Tasks;

namespace Spartan.Messaging
{
    public sealed class MessageDispatcher<T> : IMessageDispatcher<T> where T:class
    {
        private readonly IConnectionCreator _connectionCreator;
        private readonly ISerializationService _serializationService;

        public MessageDispatcher(IConnectionCreator connectionCreator, ISerializationService serializationService)
        {
            _connectionCreator = connectionCreator;
            _serializationService = serializationService;
        }

        public Task DispatchAsync(T data)
        {
            var channel = _connectionCreator.CreateChannel();
            var type = data.GetType().FullName; // we need to check against registered exchanged and queues
            var payload = _serializationService.ToByteArray(data);

            return Task.Run(
                () => channel.BasicPublish(
                exchange: "",
                routingKey: "",
                body: payload)
            );
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
