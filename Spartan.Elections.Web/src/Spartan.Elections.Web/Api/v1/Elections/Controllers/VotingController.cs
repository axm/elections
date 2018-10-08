using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ServiceFabric.Services.Remoting.Client;
using Spartan.Elections.Web.Api.v1.Elections.Requests;
using Spartan.Elections.Web.Filters;
using Spartan.Elections.Web.Filters.Correlation;
using Spartan.Voting.Client;
using System;
using System.Threading.Tasks;


namespace Spartan.Elections.Web.Api.v1.Elections.Controllers
{
    [ApiVersion("1.0")]
    //[Route("api/v{version:apiVersion}/elections/{electionId:Guid}/[controller]")]
    [Route("api/v1/elections/voting")]
    //[Authorize]
    [AllowAnonymous] // TODO remove
    [ApiController]
    [ServiceFilter(typeof(TimestampFilter))]
    public class VotingController : ControllerBase
    {
        [HttpPost]
        [TypeFilter(typeof(CorrelationFilter))]
        public async Task<VoteResponse> VoteAsync(/*[FromQuery]Guid electionId, */[FromBody]VoteRequest request)
        {
            var electionId = Guid.NewGuid(); // TODO remove

            var proxy = ServiceProxy.Create<IVotingCommand>(new Uri(ServiceConstants.VotesServiceUri));

            await proxy.VoteAsync(new Voting.Client.Requests.VoteRequest
            {
                ElectionId = electionId,
                Timestamp = request.Timestamp,
                Data = request.Data
            });

            return new VoteResponse();
        }
    }
}