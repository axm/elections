using System;
using Spartan.Elections.Web.Api.Common.Requests;

namespace Spartan.Elections.Web.Api.Elections.Requests
{
    public sealed class VoteRequest : ITimestampRequest
    {
        public DateTime Timestamp { get; set; }
        public object Data { get; set; }
    }
}
