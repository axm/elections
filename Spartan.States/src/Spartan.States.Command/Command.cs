using System;
using System.Collections.Generic;
using System.Fabric;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using Spartan.ServiceFabric;

namespace Spartan.States.Command
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class Command : SpartanStatelessService
    {
        public Command(StatelessServiceContext context)
            : base(context)
        { }
        
    }
}
