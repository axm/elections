using System;

namespace Spartan.Elections.Web.Api.v1.Common.Requests
{
    public abstract class BaseResponse
    {
        public ResponseLink[] Links { get; set; } = Array.Empty<ResponseLink>();
    }
}
