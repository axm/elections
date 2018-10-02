using System;
using System.Configuration;

namespace Spartan.Messaging.RabbitMq.Config
{
    public sealed class ExchangesConfigurationElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ExchangeConfigurationElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ExchangeConfigurationElement)element).Name;
        }
    }
}
