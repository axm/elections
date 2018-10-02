using RabbitMQ.Client;

namespace Spartan.RabbitMq.Config.Config.Factories
{
    public interface IRabbitMqConnectionFactory
    {
        IConnectionFactory Build();
    }

}
