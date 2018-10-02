using RabbitMQ.Client;

namespace Spartan.Persons.Services.Events
{
    public interface IRabbitConnectionManager
    {
        IConnection GetConnection();
    }
}
