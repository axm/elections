using System;
using System.Collections.Generic;
using System.Fabric;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using Spartan.Counties.Client;
using Spartan.ServiceFabric;

namespace Spartan.Counties.Voting
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class Voting : SpartanStatelessService, ICountiesVoting
    {
        public Voting(StatelessServiceContext context)
            : base(context)
        { }
    }
}
