using Microsoft.ServiceFabric.Services.Remoting;
using Spartan.Candidates.Query.Client.Requests;
using System;
using System.Threading.Tasks;

namespace Spartan.Candidates.Query.Client
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICandidatesQueryService : IService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="request"/> is null.</exception>
        Task<GetCandidateResponse> GetCandidate(GetCandidateRequest request);
    }
}
