using System.Configuration;

namespace Spartan.Messaging.RabbitMq.Config
{
    public sealed class RabbitMqConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("Exchanges")]
        [ConfigurationCollection(typeof(ExchangesConfigurationElementCollection), AddItemName = "Exchange")]
        public ExchangesConfigurationElementCollection Exchanges
        {
            get
            {
                return (ExchangesConfigurationElementCollection)this["Exchanges"];
            }
        }
    }
}
