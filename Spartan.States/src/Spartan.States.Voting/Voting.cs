using System.Fabric;
using Spartan.ServiceFabric;
using Spartan.States.Client;

namespace Spartan.States.Voting
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class Voting : SpartanStatelessService, IStatesVoting
    {
        public Voting(StatelessServiceContext context)
            : base(context)
        { }
    }
}
