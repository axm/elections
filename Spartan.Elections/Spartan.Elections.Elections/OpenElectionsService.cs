using System.Fabric;
using Spartan.ServiceFabric;
using Spartan.Elections.Client.Queries;
using SimpleInjector;
using Spartan.Elections.Client.Queries.Requests;
using System.Threading.Tasks;

namespace Spartan.Elections.Elections
{
    internal sealed class OpenElectionsService : SpartanStatelessService, IOpenElectionsQueryService
    {
        public OpenElectionsService(StatelessServiceContext serviceContext, Container container) : base(serviceContext)
        {
        }

        public Task<GetOpenElectionResponse> GetOpenElectionAsync(GetOpenElectionRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
