using System.Fabric;
using System.Threading.Tasks;
using Spartan.ServiceFabric;
using Spartan.Voting.Client.Events;

namespace Spartan.Voting.US.Presidential.EventConsumers
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class EventConsumers : RabbitMqEventConsumer<VoteSubmittedEvent>
    {
        public EventConsumers(StatelessServiceContext context)
            : base(context)
        { }

        protected override Task OnMessageReceived(VoteSubmittedEvent message)
        {
            throw new System.NotImplementedException();
        }
    }
}
