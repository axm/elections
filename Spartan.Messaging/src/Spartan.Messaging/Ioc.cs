using SimpleInjector;
using Spartan.Messaging.RabbitMq;
using Spartan.Messaging.RabbitMq.Implementation;

namespace Spartan.Messaging
{
    public static class Ioc
    {
        public static void AddMessaging(this Container container)
        {
            container.Register<IConnectionCreator, ConnectionCreator>();

        }
    }
}
