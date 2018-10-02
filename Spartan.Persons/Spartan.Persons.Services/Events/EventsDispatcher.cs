using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;
using System.Threading.Tasks;
using Validation;

namespace Spartan.Persons.Services.Events
{
    public sealed class EventsDispatcher<T> : IEventsDispatcher<T> where T: class
    {
        private readonly IRabbitConnectionManager _rabbitConnectionManager;

        public EventsDispatcher(IRabbitConnectionManager rabbitConnectionManager)
        {
            Requires.NotNull(rabbitConnectionManager, nameof(rabbitConnectionManager));

            _rabbitConnectionManager = rabbitConnectionManager;
        }

        public void Dispatch(T @event)
        {
            var json = JsonConvert.SerializeObject(@event);

            using (var connection = _rabbitConnectionManager.GetConnection())
            using (var channel = connection.CreateModel())
            {
                channel.BasicPublish(
                    exchange: "",
                    routingKey: "hello",
                    basicProperties: null,
                    body: Encoding.UTF8.GetBytes(json)
                );

                channel.Close();
            }
        }
    }
}
