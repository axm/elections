using System.Collections.Generic;
using System.Fabric;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using Microsoft.ServiceFabric.Services.Remoting.Runtime;
using Spartan.Elections.Command.Client;
using Spartan.Elections.Command.Client.Requests;
using System.Threading.Tasks;
using Validation;
using SimpleInjector;
using Spartan.Mappings;
using Spartan.Elections.Services.Command;

namespace Spartan.Elections.CommandService
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class CommandService : StatelessService, IElectionsCommandService
    {
        private readonly Container _container;
        private readonly IMappingService _mappingService;

        public CommandService(StatelessServiceContext context, Container container)
            : base(context)
        {
            Requires.NotNull(container, nameof(container));

            _container = container;
            _mappingService = container.GetInstance<IMappingService>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="request"/> is null.</exception>
        public async Task Create(CreateElectionRequest request)
        {
            Requires.NotNull(request, nameof(request));

            var _request = _mappingService.Map<Types.Command.Requests.CreateElectionRequest>(request);

            await _container.GetInstance<IElectionCommandHandler>().Create(_request);
        }

        /// <summary>
        /// Optional override to create listeners (e.g., TCP, HTTP) for this service replica to handle client or user requests.
        /// </summary>
        /// <returns>A collection of listeners.</returns>
        protected override IEnumerable<ServiceInstanceListener> CreateServiceInstanceListeners()
        {
            return this.CreateServiceRemotingInstanceListeners();
        }
    }
}
