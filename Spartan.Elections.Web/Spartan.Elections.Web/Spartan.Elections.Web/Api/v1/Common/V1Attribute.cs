using Microsoft.AspNetCore.Mvc;

namespace Spartan.Elections.Web.Api.v1.Common
{
    internal sealed class V1Attribute : ApiVersionAttribute
    {
        public V1Attribute() : base(Common.Versions.V1)
        {
        }
    }
}
