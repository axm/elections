using System;
using System.Fabric;
using System.Threading.Tasks;
using SimpleInjector;
using Spartan.Mappings;
using Spartan.Persons.Query.Client;
using Spartan.Persons.Query.Client.Requests;
using Spartan.Persons.Services.Services;
using Spartan.ServiceFabric;
using Validation;

namespace Spartan.Persons.QueryService
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class QueryService : SpartanStatelessService, IPersonsQueryService
    {
        private readonly Container _container;
        private readonly IPersonsService _handler;

        public QueryService(StatelessServiceContext context, Container container)
            : base(context)
        {
            Requires.NotNull(context, nameof(context));
            Requires.NotNull(container, nameof(container));

            _container = container;
            _handler = container.GetInstance<IPersonsService>();
        }

        public Task<FindPersonsResponse> FindPersons(FindPersonsRequest request) => _handler.FindPersons(request);

        public Task<GetPersonResponse> GetPerson(GetPersonRequest request) => _handler.GetPerson(request);
    }
}
