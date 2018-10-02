using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using Microsoft.ServiceFabric.Services.Remoting;
using Microsoft.ServiceFabric.Services.Remoting.Runtime;
using Newtonsoft.Json;
using Nito.AsyncEx.Synchronous;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Spartan.RabbitMq.Config;
using Spartan.RabbitMq.Config.Config.Factories;
using System;
using System.Collections.Generic;
using System.Fabric;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Spartan.Persons.EventConsumers
{
    internal abstract class RabbitMqEventConsumer<TEvent> : StatelessService, IService where TEvent: class
    {
        private readonly IRabbitMqConnectionFactory _rabbitMqConnectionFactory;

        public RabbitMqEventConsumer(StatelessServiceContext context, IRabbitMqConnectionFactory rabbitMqConnectionFactory)
            : base(context)
        {
            _rabbitMqConnectionFactory = rabbitMqConnectionFactory;
        }

        protected override IEnumerable<ServiceInstanceListener> CreateServiceInstanceListeners() => this.CreateServiceRemotingInstanceListeners();

        protected sealed override Task RunAsync(CancellationToken cancellationToken)
        {
            var factory = _rabbitMqConnectionFactory.Build();

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(Exchange.PersonCreated, RabbitMQ.Client.ExchangeType.Direct, durable: true, autoDelete: false, null);

                var queueName = channel.QueueDeclare().QueueName;
                channel.QueueBind(queue: queueName, exchange: Exchange.PersonCreated, routingKey: Exchange.PersonCreated);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += Consumer_Received;
                channel.BasicConsume(queue: queueName, autoAck: true, consumer: consumer);
            }

            return Task.CompletedTask;
        }

        private void Consumer_Received(object sender, BasicDeliverEventArgs e)
        {
            var serializedMessage = Encoding.UTF8.GetString(e.Body);
            var message = JsonConvert.DeserializeObject<TEvent>(serializedMessage);

            HandleEvent(message).WaitAndUnwrapException();
        }

        protected internal abstract Task HandleEvent(TEvent _event);
    }
}
