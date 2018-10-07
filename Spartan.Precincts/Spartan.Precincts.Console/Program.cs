using Spartan.Messaging.Implementation;
using Spartan.Messaging.RabbitMq.Config;
using Spartan.Messaging.RabbitMq.Implementation;
using Spartan.Precincts.Client.Events;
using Spartan.Serialization;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace Spartan.Precincts.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var messageDispatcher = new MessageDispatcher<PrecinctVoteCompleteEvent>(
                new ConnectionCreator(),
                new SerializationService()
            );

            await messageDispatcher.DispatchAsync(new PrecinctVoteCompleteEvent
            {
                EventTimestamp = DateTime.UtcNow,
                PrecinctId = Guid.NewGuid().ToString()
            });

            //SetupRabbitMq();
        }

        private static void SetupRabbitMq()
        {
            var rabbitMqSection = ConfigurationManager.GetSection("RabbitMq") as RabbitMqConfigSection;
            var exchanges = rabbitMqSection.Exchanges;

            var connectionCreator = new ConnectionCreator();
            var channel = connectionCreator.CreateChannel();
            var routing = new Dictionary<string, string>();

            foreach (ExchangeConfigurationElement exchange in exchanges)
            {
                var queues = exchange.Queues;
                routing.Add(exchange.Event, exchange.Name);

                foreach (QueueConfigurationElement queue in queues)
                {
                    channel.QueueBind(queue.Name, exchange.Name, queue.RoutingKey, null);
                }
            }
        }
    }
}
