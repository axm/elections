using System;
using System.Collections.Generic;
using System.Fabric;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Remoting;
using Microsoft.ServiceFabric.Services.Remoting.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using Spartan.Persons.Events;
using Spartan.RabbitMq.Config.Config.Factories;

namespace Spartan.Persons.EventConsumers
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class NewPersonEventConsumer : RabbitMqEventConsumer<PersonCreatedEvent>
    {
        public NewPersonEventConsumer(StatelessServiceContext context, IRabbitMqConnectionFactory rabbitMqConnectionFactory)
            : base(context, rabbitMqConnectionFactory)
        {
        }

        protected internal override Task HandleEvent(PersonCreatedEvent _event)
        {
            return Task.CompletedTask;
        }
    }
}
