using System;

namespace Spartan.Elections.Web.Api.Common.Requests
{
    public abstract class BaseResponse
    {
        public ResponseLink[] Links { get; set; } = Array.Empty<ResponseLink>();
    }
}
