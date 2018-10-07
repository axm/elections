using Microsoft.AspNetCore.Mvc;
using Spartan.Elections.Web.Api.v1.Common;
using Spartan.Elections.Web.Api.v1.Elections.Requests;
using System;
using System.Threading.Tasks;

namespace Spartan.Elections.Web.Api.v1.Elections.Controllers
{
    [ApiVersion("1.0")]
    [Route(Routes.Elections)]
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