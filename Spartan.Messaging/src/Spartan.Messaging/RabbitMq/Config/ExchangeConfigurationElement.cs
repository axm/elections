using System.Configuration;

namespace Spartan.Messaging.RabbitMq.Config
{
    public sealed class ExchangeConfigurationElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get
            {
                return (string)this["name"];
            }
            set
            {
                this["name"] = value;
            }
        }

        [ConfigurationProperty("type")]
        public string Type
        {
            get
            {
                return (string)this["type"];
            }
            set
            {
                this["this"] = value;
            }
        }

        [ConfigurationProperty("event")]
        public string Event
        {
            get
            {
                return (string)this["event"];
            }
            set
            {
                this["event"] = value;
            }
        }

        [ConfigurationProperty("Queues")]
        [ConfigurationCollection(typeof(QueuesConfigurationElementCollection), AddItemName = "Queue")]
        public QueuesConfigurationElementCollection Queues
        {
            get
            {
                return (QueuesConfigurationElementCollection)this["Queues"];
            }
        }
    }
}
