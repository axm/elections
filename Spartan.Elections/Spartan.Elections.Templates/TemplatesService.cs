using System;
using System.Collections.Generic;
using System.Fabric;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using Microsoft.ServiceFabric.Services.Remoting.Runtime;
using Spartan.Elections.Client.Templates;
using Spartan.Elections.Client.Templates.Requests;
using System.Threading.Tasks;
using SimpleInjector;

namespace Spartan.Elections.Templates
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class TemplatesService : StatelessService, IElectionsTemplatesService
    {
        private readonly IElectionsTemplatesService _electionTemplatesService;

        public TemplatesService(StatelessServiceContext context, Container container)
            : base(context)
        {
            _electionTemplatesService = container.GetInstance<IElectionsTemplatesService>();
        }

        public Task ArchiveAsync(ArchiveElectionTemplateRequest request) => _electionTemplatesService.ArchiveAsync(request);

        public Task CreateAsync(CreateElectionTemplateRequest request) => _electionTemplatesService.CreateAsync(request);

        /// <summary>
        /// Optional override to create listeners (e.g., TCP, HTTP) for this service replica to handle client or user requests.
        /// </summary>
        /// <returns>A collection of listeners.</returns>
        protected override IEnumerable<ServiceInstanceListener> CreateServiceInstanceListeners() => this.CreateServiceRemotingInstanceListeners();
    }
}
