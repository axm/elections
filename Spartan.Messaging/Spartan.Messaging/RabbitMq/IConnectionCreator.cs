using RabbitMQ.Client;

namespace Spartan.Messaging.RabbitMq
{
    public interface IConnectionCreator
    {
        IConnection Create();
        IModel CreateChannel();
    }
}
