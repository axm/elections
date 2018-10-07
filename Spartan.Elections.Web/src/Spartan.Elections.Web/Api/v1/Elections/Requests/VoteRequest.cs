using System;
using Spartan.Elections.Web.Api.v1.Common.Requests;

namespace Spartan.Elections.Web.Api.v1.Elections.Requests
{
    public sealed class VoteRequest : ITimestampRequest
    {
        public DateTime Timestamp { get; set; }
        public object Data { get; set; }
    }
}
