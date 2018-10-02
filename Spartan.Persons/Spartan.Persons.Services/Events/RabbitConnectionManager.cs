using RabbitMQ.Client;

namespace Spartan.Persons.Services.Events
{
    internal sealed class RabbitConnectionManager : IRabbitConnectionManager
    {
        private static IConnection Connection;

        public IConnection GetConnection()
        {
            if(Connection != null)
            {
                return Connection;
            }

            var factory = new ConnectionFactory();
            return Connection = factory.CreateConnection();
        }
    }
}
