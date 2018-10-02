using System;

namespace Spartan.Elections.Web.Api.v1.Common.Requests
{
    public interface ITimestampRequest
    {
        DateTime Timestamp { get; set; }
    }
}
