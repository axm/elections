using Microsoft.AspNetCore.Mvc;

namespace Spartan.Elections.Web.Api.v1.Monitoring.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/elections/[controller]")]
    //[ApiContext("elections")]
    //[Route("api/v{version:apiVersion}/{apiContext}/[controller]")]
    [ApiController]
    public class MonitoringController : ControllerBase
    {
    }
}