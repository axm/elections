using Spartan.Elections.Web.Api.v1.Common.Requests;
using Spartan.Elections.Web.Api.v1.Static.Models;

namespace Spartan.Elections.Web.Static.Requests
{
    public sealed class GetMenuResponse : BaseResponse
    {
        public MenuModel Menu { get; set; }
    }
}
