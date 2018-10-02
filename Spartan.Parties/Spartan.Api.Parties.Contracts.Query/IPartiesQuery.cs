using Microsoft.ServiceFabric.Services.Remoting;
using System.Threading.Tasks;
using Spartan.Api.Parties.Contracts.Query.Requests;

namespace Spartan.Api.Parties.Contracts.Query
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPartiesQuery : IService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetPartyResponse> GetParty(GetPartyRequest request);
    }
}
