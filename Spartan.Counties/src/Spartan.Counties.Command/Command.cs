using System.Fabric;
using Spartan.ServiceFabric;

namespace Spartan.Counties.Command
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
