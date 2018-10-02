using System.Threading.Tasks;
using Spartan.Elections.Client.Commands.Requests;
using Spartan.Elections.Client.Queries.Requests;

namespace Spartan.Elections.Services.Elections
{
    public interface IElectionsService
    {
        Task CreateAsync(CreateElectionRequest request);
        Task<GetElectionResponse> GetElectionAsync(GetElectionRequest request);
        Task<GetElectionsResponse> GetElectionsAsync(GetElectionsRequest request);
    }
}
