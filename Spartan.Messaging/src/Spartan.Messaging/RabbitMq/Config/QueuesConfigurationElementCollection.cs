using System;
using System.Configuration;

namespace Spartan.Messaging.RabbitMq.Config
{
    public sealed class QueuesConfigurationElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new QueueConfigurationElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((QueueConfigurationElement)element).Name;
        }
    }
}
