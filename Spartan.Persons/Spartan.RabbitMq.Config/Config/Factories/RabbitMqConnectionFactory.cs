using RabbitMQ.Client;
using System.Configuration;

namespace Spartan.RabbitMq.Config.Config.Factories
{
    public sealed class RabbitMqConnectionFactory : IRabbitMqConnectionFactory
    {
        public IConnectionFactory Build()
        {
            var section = (RabbitMqConfig)ConfigurationManager.GetSection("rabbitMqConfig");

            var username = section.Username;
            var password = section.Password;
            var virtualHost = section.VirtualHost;
            var hostName = section.HostName;
            var port = section.Port;

            return new ConnectionFactory
            {
                UserName = username,
                Password = password,
                VirtualHost = virtualHost,
                HostName = hostName,
                Port = port
            };
        }
    }

}
