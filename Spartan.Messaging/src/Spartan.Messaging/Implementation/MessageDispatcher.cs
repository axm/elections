using RabbitMQ.Client;
using Spartan.Messaging.RabbitMq;
using Spartan.Messaging.RabbitMq.Config;
using Spartan.Serialization;
using System;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Spartan.Messaging.Implementation
{
    public sealed class MessageDispatcher : IMessageDispatcher
    {
        private readonly IConnectionCreator _connectionCreator;
        private readonly ISerializationService _serializationService;

        public MessageDispatcher(IConnectionCreator connectionCreator, ISerializationService serializationService)
        {
            _connectionCreator = connectionCreator;
            _serializationService = serializationService;
        }

        public Task DispatchAsync<T>(T data) where T: class
        {
            var payload = _serializationService.ToByteArray<T>(data);

            return PublishMessageAsync<T>(payload);
        }

        private Task PublishMessageAsync<T>(byte[] payload) where T: class
        {
            var type = typeof(T).Name;
            var rabbitMqSection = ConfigurationManager.GetSection("RabbitMq") as RabbitMqConfigSection;
            var channel = _connectionCreator.CreateChannel();

            foreach (ExchangeConfigurationElement exchange in rabbitMqSection.Exchanges)
            {
                if(exchange.Event == type)
                {
                    return Task.Run(
                            () => channel.BasicPublish(
                            exchange: exchange.Name,
                            routingKey: "",
                            body: payload)
                    );
                }
            }

            throw new InvalidOperationException("No such exchange.");
        }
    }
}
