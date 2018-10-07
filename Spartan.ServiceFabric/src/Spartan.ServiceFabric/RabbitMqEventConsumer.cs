using Nito.AsyncEx.Synchronous;
using RabbitMQ.Client.Events;
using Spartan.Serialization;
using System.Fabric;
using System.Threading;
using System.Threading.Tasks;

namespace Spartan.ServiceFabric
{
    public abstract class RabbitMqEventConsumer<T> : SpartanStatelessService where T: class
    {
        private readonly ISerializationService _serializationService;

        protected RabbitMqEventConsumer(ISerializationService serializationService, StatelessServiceContext serviceContext) : base(serviceContext) 
            => _serializationService = serializationService;

        protected override Task RunAsync(CancellationToken cancellationToken)
        {
            var consumer = new EventingBasicConsumer(null);
            consumer.Received += Consumer_Received;

            return base.RunAsync(cancellationToken);
        }

        private void Consumer_Received(object sender, BasicDeliverEventArgs e)
        {
            var bytes = e.Body;

            var deserializedEvent = _serializationService.Deserialize<T>(bytes);

            OnMessageReceived(deserializedEvent).WaitAndUnwrapException();
        }

        protected abstract Task OnMessageReceived(T message);
    }
}
