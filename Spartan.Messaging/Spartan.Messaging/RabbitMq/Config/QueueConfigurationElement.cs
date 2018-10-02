using System.Configuration;

namespace Spartan.Messaging.RabbitMq.Config
{
    public sealed class QueueConfigurationElement : ConfigurationElement
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

        [ConfigurationProperty("routingKey", IsRequired = false)]
        public string RoutingKey
        {
            get
            {
                return (string)this["routingKey"];
            }
            set
            {
                this["routingKey"] = value;
            }
        }
    }
}
