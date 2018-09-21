using System;

namespace Spartan.Elections.Web.Api.Common.Requests
{
    public interface ITimestampRequest
    {
        DateTime Timestamp { get; set; }
    }
}
