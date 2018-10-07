using Microsoft.ServiceFabric.Services.Remoting;
using Spartan.Elections.Client.Queries.Requests;
using System.Threading.Tasks;

namespace Spartan.Elections.Client.Queries
{
    public interface IOpenElectionsQueryService : IService
    {
        Task<GetOpenElectionResponse> GetOpenElectionAsync(GetOpenElectionRequest request);
    }
}
