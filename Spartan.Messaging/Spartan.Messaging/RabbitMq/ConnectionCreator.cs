using RabbitMQ.Client;
using System;

namespace Spartan.Messaging.RabbitMq
{
    public sealed class ConnectionCreator : IConnectionCreator
    {
        private static IConnection Connection;
        private static IModel Channel;

        public IConnection Create()
        {
            if(Connection == null || !Connection.IsOpen)
            {
                var factory = new ConnectionFactory();
                Connection = factory.CreateConnection();
                Connection.ConnectionShutdown += Connection_ConnectionShutdown;
            }

            return Connection;
        }

        private void Connection_ConnectionShutdown(object sender, ShutdownEventArgs e)
        {
            Connection = Create();
        }

        public IModel CreateChannel()
        {
            var connection = Create();
            if(Channel == null || Channel.IsClosed)
            {
                Channel = connection.CreateModel();
            }

            return Channel;
        }
    }
}
