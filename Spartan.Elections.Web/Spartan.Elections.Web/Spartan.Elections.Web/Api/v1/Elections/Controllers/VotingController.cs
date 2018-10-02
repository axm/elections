using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ServiceFabric.Services.Remoting.Client;
using Spartan.Elections.Web.Api.v1.Elections.Requests;
using Spartan.Elections.Web.Filters.Correlation;
using Spartan.Voting.Client;
using System;
using System.Threading.Tasks;


namespace Spartan.Elections.Web.Api.v1.Elections.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/elections/[controller]")]
    [Authorize]
    [ApiController]
    public class VotingController : ControllerBase
    {
        [HttpPost("{electionId}/Voting")]
        [TypeFilter(typeof(CorrelationFilter))]
        public async Task<VoteResponse> VoteAsync([FromQuery]Guid electionId, [FromBody]VoteRequest request)
        {
            var proxy = ServiceProxy.Create<IVotingCommand>(new Uri(ServiceConstants.VotesServiceUri));

            throw new NotImplementedException();
            //await proxy.VoteAsync()
        }
    }
}