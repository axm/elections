using Spartan.Elections.Web.Api.Common.Requests;
using Spartan.Elections.Web.Api.Static.Models;

namespace Spartan.Elections.Web.Static.Requests
{
    public sealed class GetMenuResponse : BaseResponse
    {
        public MenuModel Menu { get; set; }
    }
}
