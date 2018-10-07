using Spartan.Elections.Web.Api.v1.Elections.Models;

namespace Spartan.Elections.Web.Api.v1.Elections.Requests
{
    public sealed class NewElectionRequest
    {
        public ElectionModel Election { get; set; }
    }
}
