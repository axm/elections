using Microsoft.AspNetCore.Mvc;
using Spartan.Elections.Web.Api.Parties.Requests;
using System;
using System.Threading.Tasks;

namespace Spartan.Elections.Web.Api.Parties.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
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