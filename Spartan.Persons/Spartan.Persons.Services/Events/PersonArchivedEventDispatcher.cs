using Newtonsoft.Json;
using RabbitMQ.Client;
using Spartan.Persons.Events;
using System.Text;
using System.Threading.Tasks;

namespace Spartan.Persons.Services.Events
{
    public sealed class PersonArchivedEventDispatcher : IEventsDispatcher<PersonArchivedEvent>
    {
        public void Dispatch(PersonArchivedEvent @event)
        {
            var factory = new ConnectionFactory();

            var json = JsonConvert.SerializeObject(@event);

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.BasicPublish(
                    exchange: Exchanges.AmqDirect,
                    routingKey: nameof(PersonArchivedEvent),
                    body: Encoding.UTF8.GetBytes(json)
                );
            }
        }
    }
}
