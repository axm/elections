using System;
using System.Diagnostics;
using System.Fabric;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Runtime;
using RabbitMQ.Client;
using SimpleInjector;
using Spartan.Mappings;
using Spartan.Persons.CommandService.Ioc;
using Spartan.Persons.CommandService.Mappings;

namespace Spartan.Persons.CommandService
{
    internal static class Program
    {
        /// <summary>
        /// This is the entry point of the service host process.
        /// </summary>
        private static void Main()
        {
            try
            {
                //CreateQueues();

                var container = new Container();
                container.AddCommandServices();

                ServiceRuntime.RegisterServiceAsync("Spartan.Persons.CommandServiceType",
                    context => new CommandService(context, container)).GetAwaiter().GetResult();

                ServiceEventSource.Current.ServiceTypeRegistered(Process.GetCurrentProcess().Id, typeof(CommandService).Name);

                // Prevents this host process from terminating so services keep running.
                Thread.Sleep(Timeout.Infinite);
            }
            catch (Exception e)
            {
                ServiceEventSource.Current.ServiceHostInitializationFailed(e.ToString());
                throw;
            }
        }

        private static void CreateQueues()
        {
            var factory = new ConnectionFactory { };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                CreateQueue(channel, nameof(Spartan.Persons.Events.PersonArchivedEvent));
                CreateQueue(channel, nameof(Spartan.Persons.Events.PersonCreatedEvent));
                CreateQueue(channel, nameof(Spartan.Persons.Events.PersonModifiedEvent));

                channel.Close();
                connection.Close();
            }
        }

        private static void CreateQueue(IModel channel, string queueName)
        {
            channel.QueueDeclare(queue: queueName,
                                durable: false,
                                exclusive: false,
                                autoDelete: false,
                                arguments: null);
        }
    }
}
