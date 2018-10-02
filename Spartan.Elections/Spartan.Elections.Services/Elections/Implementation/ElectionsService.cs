using System.Threading.Tasks;
using Spartan.Elections.Client.Commands.Requests;
using Spartan.Elections.Client.Queries.Requests;

namespace Spartan.Elections.Services.Elections.Implementation
{
    public sealed class ElectionsService : IElectionsService
    {
        public Task CreateAsync(CreateElectionRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<GetElectionResponse> GetElectionAsync(GetElectionRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<GetElectionsResponse> GetElectionsAsync(GetElectionsRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
