using System.Fabric;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Runtime;

namespace Spartan.PartyMembers.EventConsumers
{
    abstract class RabbitMqConsumer<T> : StatelessService where T: class
    {
        protected RabbitMqConsumer(StatelessServiceContext serviceContext) : base(serviceContext)
        {
        }

        public abstract Task ConsumeAsync(T consumedEvent); 
    }
}
