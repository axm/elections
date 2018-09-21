using Spartan.Elections.Web.Api.Elections.Models;

namespace Spartan.Elections.Web.Api.Elections.Requests
{
    public sealed class NewElectionRequest
    {
        public ElectionModel Election { get; set; }
    }
}
