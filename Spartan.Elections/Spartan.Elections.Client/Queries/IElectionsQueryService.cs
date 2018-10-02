using Microsoft.ServiceFabric.Services.Remoting;
using Spartan.Elections.Client.Queries.Requests;
using System.Threading.Tasks;

namespace Spartan.Elections.Query.Client
{
    /// <summary>
    /// 
    /// </summary>
    public interface IElectionsQueryService : IService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns>
        /// A <see cref="Task"/> representing an ongoing operation. The result of the operation is an instance of <see cref="GetElectionResponse"/>.
        /// </returns>
        Task<GetElectionResponse> GetElection(GetElectionRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns>
        /// A <see cref="Task"/> representing an ongoing operation. The result of the operation is an instance of <see cref="GetElectionResponse"/>.
        /// </returns>
        Task<GetElectionsResponse> GetElections(GetElectionsRequest request);
    }
}
