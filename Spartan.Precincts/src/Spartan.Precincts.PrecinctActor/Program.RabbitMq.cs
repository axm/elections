using Spartan.Messaging.RabbitMq.Config;
using System.Configuration;

namespace Spartan.Precincts.PrecinctActor
{
    internal static partial class Program
    {

        private static void SetupRabbitMq()
        {
            var rabbitMqSection = ConfigurationManager.GetSection("RabbitMq") as RabbitMqConfigSection;
            var exchanges = rabbitMqSection.Exchanges;

            foreach (ExchangeConfigurationElement exchange in exchanges)
            {
                var queues = exchange.Queues;
            }
        }
    }
}
