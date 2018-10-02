using System.Collections.Generic;
using System.Fabric;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Remoting.Runtime;
using SimpleInjector;
using Spartan.Mappings;
using Spartan.Persons.Command.Client;
using Spartan.Persons.Command.Client.Requests;
using Spartan.Persons.Services.Logging;
using Spartan.Persons.Services.Services;
using Spartan.ServiceFabric;
using Validation;

namespace Spartan.Persons.CommandService
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class CommandService : SpartanStatelessService, IPersonsCommandService
    {
        private readonly Container _container;
        private IPersonsService _handler;

        public CommandService(StatelessServiceContext context, Container container)
            : base(context)
        {
            Requires.NotNull(context, nameof(context));
            Requires.NotNull(container, nameof(container));

            _container = container;
            _handler = container.GetInstance<IPersonsService>();
        }

        public Task Archive(ArchivePersonRequest request) => _handler.Archive(request);

        public Task Create(CreatePersonRequest request) => _handler.Create(request);

        public Task Edit(EditPersonRequest request) => _handler.Edit(request);

        protected override IEnumerable<ServiceInstanceListener> CreateServiceInstanceListeners() => this.CreateServiceRemotingInstanceListeners();
    }
}
