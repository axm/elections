using Microsoft.AspNetCore.Mvc;
using Spartan.Elections.Web.Api.v1.Common;
using Spartan.Elections.Web.Api.v1.Parties.Requests;
using System;
using System.Threading.Tasks;

namespace Spartan.Elections.Web.Api.v1.Parties.Controllers
{
    [ApiVersion("1.0")]
    [Route(Routes.Parties)]
    [ApiController]
    public class PartiesController : ControllerBase
    {
        [HttpPost("")]
        public async Task Create(CreatePartyRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpPut("")]
        public async Task Edit(EditPartyRequest request)
        {
            throw new NotImplementedException();
        }
    }
}