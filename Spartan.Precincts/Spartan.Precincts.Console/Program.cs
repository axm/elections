using Spartan.Messaging.RabbitMq;
using Spartan.Messaging.RabbitMq.Config;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartan.Precincts.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            SetupRabbitMq();
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
