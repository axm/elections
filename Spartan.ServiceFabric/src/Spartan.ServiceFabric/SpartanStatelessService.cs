using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using System;
using System.Collections.Generic;
using System.Fabric;

namespace Spartan.ServiceFabric
{
    public abstract class SpartanStatelessService : StatelessService
    {
        protected SpartanStatelessService(StatelessServiceContext serviceContext) : base(serviceContext)
        {
        }

        protected override IEnumerable<ServiceInstanceListener> CreateServiceInstanceListeners()
            => CreateServiceInstanceListeners();
    }
}
