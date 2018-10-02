using Bogus;
using Newtonsoft.Json;
using RabbitMQ.Client;
using Spartan.Persons.ThrowawayConsole.Commands;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Spartan.Persons.ThrowawayConsole.Events
{
    internal sealed class PublishPersonCreatedEvent : IConsoleCommand
    {
        public Task Execute()
        {
            var factory = new ConnectionFactory { };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                CreateQueue(channel, nameof(Spartan.Persons.Events.PersonArchivedEvent));
                CreateQueue(channel, nameof(Spartan.Persons.Events.PersonCreatedEvent));
                CreateQueue(channel, nameof(Spartan.Persons.Events.PersonModifiedEvent));

                var personCreatedEvent = new Spartan.Persons.Events.PersonCreatedEvent
                {
                    PersonId = Guid.NewGuid()
                };
                var body = JsonConvert.SerializeObject(personCreatedEvent);

                channel.BasicPublish(exchange: "",
                                     routingKey: nameof(Spartan.Persons.Events.PersonCreatedEvent),
                                     basicProperties: null,
                                     body: Encoding.UTF8.GetBytes(body));
            }

            return Task.CompletedTask;
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
