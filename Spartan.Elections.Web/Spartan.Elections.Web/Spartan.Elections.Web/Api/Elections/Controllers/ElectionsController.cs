using Microsoft.AspNetCore.Mvc;
using Spartan.Elections.Web.Api.Elections.Requests;
using System;
using System.Threading.Tasks;

namespace Spartan.Elections.Web.Api.Elections.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/elections/[controller]")]
    [ApiController]
    public class ElectionsController : ControllerBase
    {
        [HttpPost]
        public async Task Post(NewElectionRequest request)
        {
            throw new NotImplementedException();
        }
    }
}