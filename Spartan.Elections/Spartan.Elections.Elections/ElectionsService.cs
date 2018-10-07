using System.Collections.Generic;
using System.Fabric;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using Spartan.Elections.Client.Queries.Requests;
using Spartan.Elections.Client.Commands;
using Spartan.Elections.Client.Commands.Requests;
using Spartan.Elections.Query.Client;
using Spartan.Elections.Services.Elections;
using SimpleInjector;
using Microsoft.ServiceFabric.Services.Remoting.Runtime;
using Spartan.ServiceFabric;

namespace Spartan.Elections.Elections
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class ElectionsService : SpartanStatelessService, IElectionsCommandService, IElectionsQueryService
    {
        private readonly IElectionsService _electionsService;

        public ElectionsService(StatelessServiceContext context, Container container) : base(context)
        {
            _electionsService = container.GetInstance<IElectionsService>();
        }

        public Task Create(CreateElectionRequest request) => _electionsService.CreateAsync(request);

        public Task<GetElectionResponse> GetElection(GetElectionRequest request) => _electionsService.GetElectionAsync(request);

        public Task<GetElectionsResponse> GetElections(GetElectionsRequest request) => _electionsService.GetElectionsAsync(request);
    }
}
