using Microsoft.AspNetCore.Mvc;

namespace Spartan.Elections.Web.Api.Elections.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/elections/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
    }
}