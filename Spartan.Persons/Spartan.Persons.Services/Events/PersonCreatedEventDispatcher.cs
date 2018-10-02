using Newtonsoft.Json;
using RabbitMQ.Client;
using Spartan.Persons.Events;
using System.Text;
using System.Threading.Tasks;

namespace Spartan.Persons.Services.Events
{
    public sealed class PersonCreatedEventDispatcher : IEventsDispatcher<PersonCreatedEvent>
    {
        public void Dispatch(PersonCreatedEvent @event)
        {
            var factory = new ConnectionFactory();

            var json = JsonConvert.SerializeObject(@event);

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.BasicPublish(
                    exchange: Exchanges.AmqDirect,
                    routingKey: nameof(PersonCreatedEvent),
                    body: Encoding.UTF8.GetBytes(json)
                );
            }
        }
    }
}
